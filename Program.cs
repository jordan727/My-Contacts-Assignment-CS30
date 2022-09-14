// My Contacts by Jordan. A
#nullable disable

Console.Clear();

// Random Object
Random rnd = new Random();

List<Contact> contacts = new List<Contact>();

bool loop = true;

// Class contains Function
bool classContains(List<Contact> aList, string contains) {
    for (int n = 0; n < aList.Count; n++) {
        if (aList[n].name == contains) {
            return true;
        } 
    }
    return false;
}

// Welcome
while (loop) {
    Console.WriteLine("\nMAIN MENU");
    Console.WriteLine("1. DISPLAY CONTACT NAMES");
    Console.WriteLine("2. SEARCH FOR CONTACT");
    Console.WriteLine("3. EDIT CONTACT");
    Console.WriteLine("4. NEW CONTACT");
    Console.WriteLine("5. REMOVE CONTACT");
    Console.WriteLine("6. EXIT\n");
    string option = Console.ReadLine();

    if (option == "1") {
        // DISPLAY CONTACT NAMES
          for(int n = 0; n < contacts.Count; n++) {
            Console.WriteLine($"{contacts[n].name}");
        }

    } else if (option == "2") {
        // SEARCH FOR CONTACT
        Console.Write("ENTER A CONTACTS NAME: ");
        string search = Console.ReadLine();
        if (classContains(contacts, search)) {
            for(int n = 0; n < contacts.Count; n++) {
                if (search == contacts[n].name) {
                    Console.WriteLine($"Name: {contacts[n].name}");
                    Console.WriteLine($"Phone Number: {contacts[n].phone}");
                    Console.WriteLine($"Email: {contacts[n].email}");
                }
            }
        } else {
            Console.WriteLine("CONTACT DOES NOT EXIST");
        }

    } else if (option == "3") {
        Console.Write("ENTER A CONTACTS NAME: ");
        string edit = Console.ReadLine();
        if (classContains(contacts, edit)) {
            for (int n = 0; n < contacts.Count; n++) {
                if (contacts[n].name == edit) {
                    Console.Write("Edit Contacts Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Edit Contacts Phone Number: ");
                    string phoneNum = Console.ReadLine();
                    Console.Write("Edit Contacts Email: ");
                    string email = Console.ReadLine();
                    contacts[n].name = name;
                    contacts[n].phone = phoneNum;
                    contacts[n].email = email;
                }
            }
        } else {
            Console.WriteLine("CONTACT DOES NOT EXIST");
        }

    } else if (option == "4") {
        // NEW CONTACT
        Console.Write("ENTER CONTACTS NAME: ");
        string name = Console.ReadLine();
        if (classContains(contacts, name)) {
            Console.WriteLine("A CONTACT WITH THAT NAME ALREADY EXIST");
        } else {
            Console.Write("ENTER CONTACTS PHONENUMBER: ");
            string phoneNum = Console.ReadLine();
            Console.Write("ENTER CONTACTS EMAIL: ");
            string email = Console.ReadLine();
            contacts.Add(new Contact(name, phoneNum, email));
            Console.WriteLine("NEW CONTACT CREATED");
        }
    } else if (option == "5") {
        // REMOVE CONTACT
        Console.Write("ENTER A CONTACTS NAME TO REMOVE: ");
        string remove = Console.ReadLine();
        if (classContains(contacts, remove)) {
            for (int n = 0; n < contacts.Count; n++) {
                if (contacts[n].name == remove) {
                    contacts.RemoveAt(n);
                    Console.WriteLine("CONTACT HAS BEEN REMOVED");
                }
            }
        } else {
            Console.WriteLine("CONTACT DOES NOT EXIST");
        }
    } else if (option == "6") {
        loop = false;
    }
}

// Contact Constructer
class Contact {
    public string name;
    public string phone;
    public string email;

    public Contact(string contactName, string contactPhone, string contactEmail) {
        name = contactName;
        phone = contactPhone;
        email = contactEmail;
    }
}