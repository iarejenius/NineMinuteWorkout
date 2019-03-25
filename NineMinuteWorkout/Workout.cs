using System.Collections.Generic;

namespace NineMinuteWorkout
{
    class Workout : Queue<Activity>
    {
        public Workout()
        {
            Populate();
        }

        public void Reset()
        {
            this.Clear();
            this.Populate();
        }

        private void Populate()
        {
            var standardActivityDuration = 60;

            this.Enqueue(new Activity
            {
                Name = "Squats",
                AudioFilePath = "sounds/squats.mp3",
                Duration = standardActivityDuration
            });

            // pushups
            this.Enqueue(new Activity
            {
                Name = "Pushups",
                AudioFilePath = "sounds/pushups.mp3",
                Duration = standardActivityDuration
            });


            // mountain climbers
            this.Enqueue(new Activity
            {
                Name = "Mountain climbers",
                AudioFilePath = "sounds/mountain-climbers.mp3",
                Duration = standardActivityDuration
            });

            // break
            this.Enqueue(new Activity
            {
                Name = "Break",
                AudioFilePath = "sounds/break.mp3",
                Duration = standardActivityDuration
            });

            // forearm plank
            this.Enqueue(new Activity
            {
                Name = "Forearm plank",
                AudioFilePath = "sounds/forearm-plank.mp3",
                Duration = standardActivityDuration
            });

            // split squat
            this.Enqueue(new Activity
            {
                Name = "Split squat",
                AudioFilePath = "sounds/split-squat.mp3",
                Duration = standardActivityDuration
            });

            // single leg raise
            this.Enqueue(new Activity
            {
                Name = "Single leg raise",
                AudioFilePath = "sounds/single-leg-hip-raise.mp3",
                Duration = standardActivityDuration
            });

            // break
            this.Enqueue(new Activity
            {
                Name = "Break",
                AudioFilePath = "sounds/break.mp3",
                Duration = standardActivityDuration
            });

            // burpee with pushup
            this.Enqueue(new Activity
            {
                Name = "Burpee with pushup",
                AudioFilePath = "sounds/burpee-with-pushups.mp3",
                Duration = standardActivityDuration
            });

            // single leg toe touch
            this.Enqueue(new Activity
            {
                Name = "Single leg toe touches",
                AudioFilePath = "sounds/single-leg-toe-touches.mp3",
                Duration = standardActivityDuration
            });

            // leg raises
            this.Enqueue(new Activity
            {
                Name = "Leg raises",
                AudioFilePath = "sounds/leg-raises.mp3",
                Duration = standardActivityDuration
            });

            // finished
            this.Enqueue(new Activity
            {
                Name = "Finished",
                AudioFilePath = "sounds/finished.mp3",
                Duration = 1
            });

        }
    }
}