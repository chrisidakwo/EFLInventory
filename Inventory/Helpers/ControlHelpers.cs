using System.Windows.Forms;
using ToastNotification;
using static Inventory.ToastNotification.NotificationSound;
using static ToastNotification.FormAnimator;

namespace Inventory.View.Helpers {
    public class ControlHelpers {
        public static void DisplayUserControl(SplitContainer sc, Control.ControlCollection cc) {
            sc.Panel2.Controls.Clear();
            var controls = cc;
            foreach (Control control in controls) {
                sc.Panel2.Controls.Add(control);
            }
        }

        public static void StartUpNotification(string title, string body, int duration = -1) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.StartUp);
            n.Show();
        }

        public static void SuccessNotification(string title, string body, int duration = 7) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.Success);
            n.Show();
        }

        public static void ErrorNotification(string title, string body, int duration = 7) {
            Notification n = new Notification(title, body, duration, AnimationMethod.Slide, AnimationDirection.Up);
            PlayNotificationSound(Sounds.Error);
            n.Show();
        }
    }
}