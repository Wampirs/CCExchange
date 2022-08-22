using CCExchange.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CCExchange.Commands
{
    public class ChangeThemeCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            App.Services.GetRequiredService<IThemeService>().ChangeTheme();
        }
    }
}
