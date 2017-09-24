using System.Windows.Forms;
using ToastNotification;
using static Inventory.ToastNotification.NotificationSound;
using static ToastNotification.FormAnimator;

namespace Inventory.View.Helpers {
    public class ControlHelpers {
        public static void DisplayUserControl(Panel panel, Control.ControlCollection cc) {
            panel.Controls.Clear();
            var controls = cc;
            foreach (Control control in controls) {
                panel.Controls.Add(control);
            }
        }

        public static void StartUpNotification(string title, string body, int duration = -1) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.StartUp);
            n.Show();
        }

        public static void SuccessNotification(string title, string body, int duration = 10) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.Success);
            n.Show();
        }

        public static void PromptNotification(string title, string body, int duration = 10) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.Prompt);
            n.Show();
        }

        public static void ErrorNotification(string title, string body, int duration = 10) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.Error);
            n.Show();
        }
    }
}
