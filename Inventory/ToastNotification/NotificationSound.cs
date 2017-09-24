using System;
using System.ComponentModel;
using System.IO;
using System.Media;

namespace Inventory.ToastNotification {
    public static class NotificationSound {
        public enum Sounds {
            [Description("Error Notification")]
            Error = 0,

            [Description("Prompt Notification")]
            Prompt = 1,

            [Description("Success Notification")]
            Success = 2,

            [Description("Application StartUp")]
            StartUp = 3
        }

        public static void PlayNotificationSound(Sounds soundType) {
            //var soundsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds");
            var soundsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds");
            var soundFile = "";
            switch (soundType) {
                case Sounds.Error:
                    soundFile = Path.Combine(soundsFolder, "error.wav");
                    break;
                case Sounds.Prompt:
                    soundFile = Path.Combine(soundsFolder, "prompt.wav");
                    break;
                case Sounds.Success:
                    soundFile = Path.Combine(soundsFolder, "success.wav");
                    break;
                case Sounds.StartUp:
                    soundFile = Path.Combine(soundsFolder, "startup.wav");
                    break;
            }

            using (var player = new SoundPlayer(soundFile)) {
                player.Play();
            }
        }
    }
}
