using System;

class AmbulenceRouteMenu
{
    private IAmbulenceRoute route;

    public void ShowAmbulenceRouteMenu()
    {
        route = new AmbulenceRouteUtility();

        int choice;

        do
        {
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Show All Patients");
            Console.WriteLine("3. Show Available Buildings");
            Console.WriteLine("4. Show Buildings Under Maintenance");
            Console.WriteLine("5. Redirect Patient");
            Console.WriteLine("6. Toggle Building Maintenance Status");
            Console.WriteLine("0. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    route.AddPatient();
                    break;
                case 2:
                    route.ShowAllPatients();
                    break;
                case 3:
                    route.ShowAvailableBuildings();
                    break;
                case 4:
                    route.ShowBuildingsUnderMaintenance();
                    break;
                case 5:
                    route.RedirectPatient();
                    break;
                case 6:
                    route.RemoveBuildingForMaintenance();
                    break;
            }

        } while (choice != 0);
    }
}
