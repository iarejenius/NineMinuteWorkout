using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Media;
using System;

namespace NineMinuteWorkout
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Workout workout;

        private Button startButton;
        private Button cancelButton;
        private Handler handler;
        private MediaPlayer player;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            
            player = new MediaPlayer();
            workout = new Workout();

            startButton = FindViewById<Button>(Resource.Id.startButton);
            startButton.Click += StartButtonOnClick;

            cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            cancelButton.Click += CancelButtonOnClick;
        }

        private void StartButtonOnClick(object sender, EventArgs eventArgs)
        {
            startButton.Enabled = false;
            cancelButton.Enabled = true;
            StartNextActivity(workout);
        }

        private void CancelButtonOnClick(object sender, EventArgs eventArgs)
        {
            handler.RemoveCallbacksAndMessages(null);
            handler.Dispose();
            startButton.Enabled = true;
            cancelButton.Enabled = false;
            workout = new Workout();
        }
        
        private void StartNextActivity(Workout workout)
        {
            handler = new Handler(Looper.MainLooper);
            var activity = workout.Dequeue();
            PlayAudio(activity.AudioFilePath);
            handler.PostDelayed(() =>
            {
                if (workout.Count > 0)
                {
                    handler.Dispose();
                    StartNextActivity(workout);
                }
                else
                {
                    startButton.Enabled = true;
                    cancelButton.Enabled = false;
                    handler = null;
                }

            }, ((long)activity.Duration * 1000));
        }

        private void PlayAudio(string filePath)
        {
            var fd = Application.Context.Assets.OpenFd(filePath);
            player.Reset();
            player.SetDataSource(fd);
            player.Prepare();
            player.Start();
        }

    }
}