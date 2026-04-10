using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace signaller_scenario_maker.Components.Pages
{
    public partial class Dashboard : ComponentBase
    {
        private RouteForm routeForm { get; set; } = new();
        private Dictionary<int, List<string>> routes = new();
        private List<string> currentRoute = new();

        private void RouteFormKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter") RouteSubmit();
        }

        private void RouteSubmit()
        {
            Console.WriteLine($"waypoint submitted:\n\n{routeForm.Waypoint}");

            if (routeForm.Waypoint == null || string.IsNullOrEmpty(routeForm.Waypoint)) return;

            currentRoute.Add(routeForm.Waypoint);

            routeForm.Waypoint = string.Empty;
        }
    }

    public class RouteForm
    {
        public string? Waypoint { get; set; }
    }
}
