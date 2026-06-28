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
            if (routeForm.Waypoint == null || string.IsNullOrEmpty(routeForm.Waypoint)) return;

            currentRoute.Add(routeForm.Waypoint);

            routeForm.Waypoint = string.Empty;
        }

        private void MoveWaypointUp(int waypointIndex)
        {
            if (waypointIndex == 0) return;
            (currentRoute[waypointIndex], currentRoute[waypointIndex - 1]) =
                (currentRoute[waypointIndex - 1], currentRoute[waypointIndex]);
        }

        private void MoveWaypointDown(int waypointIndex)
        {
            Console.WriteLine(waypointIndex);
            if (waypointIndex >= currentRoute.Count - 1) return;
            (currentRoute[waypointIndex], currentRoute[waypointIndex + 1]) =
                (currentRoute[waypointIndex + 1], currentRoute[waypointIndex]);
        }

        private void CreateRoute()
        {
            int id = routes.Count + 1;
            routes[id] = currentRoute;
            currentRoute = new();
        }

    }

    public class RouteForm
    {
        public string? Waypoint { get; set; }
    }
}
