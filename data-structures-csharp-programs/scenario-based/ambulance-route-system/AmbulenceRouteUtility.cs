using System;
using System.Collections.Generic;

class AmbulenceRouteUtility : IAmbulenceRoute
{
    private CircularLinkedList buildings;
    private List<Patient> patients;

    public AmbulenceRouteUtility()
    {
        buildings = new CircularLinkedList();
        patients = new List<Patient>();

        AddInitialBuildings();
    }

    private void AddInitialBuildings()
    {
        AddBuilding("Emergency", true);
        AddBuilding("Radiology", false);
        AddBuilding("Surgery", true);
        AddBuilding("ICU", true);
    }

    private void AddBuilding(string name, bool availability)
    {
        Building building = new Building();
        building.SetName(name);
        building.SetAvailability(availability);
        buildings.Add(building);
    }

    public void AddPatient()
    {
        Patient patient = new Patient();

        Console.Write("\nEnter Patient Name: ");
        patient.SetPatientName(Console.ReadLine());

        Console.WriteLine("Severity Level");
        Console.WriteLine("1 - Low");
        Console.WriteLine("2 - Medium");
        Console.WriteLine("3 - High");
        Console.Write("Select Option: ");

        patient.SetSeverity(Convert.ToInt32(Console.ReadLine()));

        patients.Add(patient);

        Console.WriteLine("\nPatient added successfully.\n");
    }

    public void ShowAllPatients()
    {
        Console.WriteLine("\n--- Patient List ---");

        if (patients.Count == 0)
        {
            Console.WriteLine("No patients available.\n");
            return;
        }

        foreach (Patient patient in patients)
        {
            Console.WriteLine(patient);
        }

        Console.WriteLine();
    }

    public void ShowAvailableBuildings()
    {
        Console.WriteLine("\n--- Available Buildings ---");

        CircularLinkedList.Node head = buildings.GetHead();
        CircularLinkedList.Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("No buildings found.\n");
            return;
        }

        bool found = false;

        do
        {
            if (temp.data.GetAvailability())
            {
                Console.WriteLine(temp.data);
                found = true;
            }

            temp = temp.next;

        } while (temp != head);

        if (!found)
            Console.WriteLine("No available buildings.");

        Console.WriteLine();
    }

    public void ShowBuildingsUnderMaintenance()
    {
        Console.WriteLine("\n--- Buildings Under Maintenance ---");

        CircularLinkedList.Node head = buildings.GetHead();
        CircularLinkedList.Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("No buildings found.\n");
            return;
        }

        bool found = false;

        do
        {
            if (!temp.data.GetAvailability())
            {
                Console.WriteLine(temp.data);
                found = true;
            }

            temp = temp.next;

        } while (temp != head);

        if (!found)
            Console.WriteLine("No buildings under maintenance.");

        Console.WriteLine();
    }

    public void RedirectPatient()
    {
        Console.WriteLine("\n--- Patient Redirection ---");

        CircularLinkedList.Node head = buildings.GetHead();
        CircularLinkedList.Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("No buildings available.\n");
            return;
        }

        do
        {
            if (temp.data.GetAvailability())
            {
                Console.WriteLine("Patient redirected to: " + temp.data.GetName() + "\n");
                return;
            }

            temp = temp.next;

        } while (temp != head);

        Console.WriteLine("No available building found.\n");
    }

    public void RemoveBuildingForMaintenance()
    {
        Console.WriteLine("\n--- Building Maintenance Toggle ---");
        Console.WriteLine("Current Building Status:\n");

        CircularLinkedList.Node head = buildings.GetHead();
        CircularLinkedList.Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("No buildings found.\n");
            return;
        }

        do
        {
            Console.WriteLine(temp.data);
            temp = temp.next;

        } while (temp != head);

        Console.Write("\nEnter Building Name to Toggle Status: ");
        string name = Console.ReadLine();

        temp = head;

        do
        {
            if (temp.data.GetName() == name)
            {
                temp.data.SetAvailability(!temp.data.GetAvailability());

                Console.WriteLine();

                if (temp.data.GetAvailability())
                    Console.WriteLine("Building is now AVAILABLE.\n");
                else
                    Console.WriteLine("Building is now UNDER MAINTENANCE.\n");

                return;
            }

            temp = temp.next;

        } while (temp != head);

        Console.WriteLine("\nBuilding not found.\n");
    }
}
