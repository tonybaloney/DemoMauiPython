using CSnakes.Runtime;

namespace DemoMauiPython
{
    public partial class MainPage : ContentPage
    {
        readonly ILittleDemo module;

        public MainPage(IPythonEnvironment env)
        {
            InitializeComponent();
            module = env.LittleDemo();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = $"Python Says : {module.OnePlusOne()}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
