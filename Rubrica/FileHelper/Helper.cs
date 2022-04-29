using System.IO;

namespace FileHelper
{
    public class Helper
    {

        private readonly string Path;
        public Helper(string path)
        {
            Path = path;
        }
        public void AddContact(Contact contact)
        {
            var result = $"{contact.nome};{contact.cognome};{contact.telefono};{contact.indirizzo}";

            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List<Contact> ReadAllContact()
        {
            var contacts = new List<Contact>();

            using (var stream = new StreamReader(Path))
            {
                var header = "nome;cognome;telefono;indirizzo";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");


                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var contact = new Contact
                    {
                        nome = splitted[0],
                        cognome = splitted[1],
                        telefono = splitted[2],
                        indirizzo = splitted[3]
                    };

                    contacts.Add(contact);
                }

                return contacts;
            }
        }


    }
}