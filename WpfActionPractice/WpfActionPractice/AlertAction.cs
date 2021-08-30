using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace WpfActionPractice
{
    /// <summary>
    /// ボタンを押したら、警告ダイアログボックスが出るということ
    /// </summary>
    public class AlertAction : TriggerAction<Button>
    {
        /// <summary>
        /// ダイアログボックスに表示する任意の文字列です
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(AlertAction), new UIPropertyMetadata(null));

        public AlertAction()
        {
        }

        /// <summary>
        /// メッセージが入力されていたらメッセージボックスを出す
        /// </summary>
        /// <param name="o"></param>
        protected override void Invoke(object o)
        {
            if (string.IsNullOrEmpty(this.Message))
            {
                return;
            }

            MessageBox.Show(this.Message);
        }
    }
}
