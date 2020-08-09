using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
                {
                new Command { Id = 0, HowTo = "Kako", Line = "La Linea", Platform = "Zvezdica" },
                new Command { Id = 1, HowTo = "Onako", Line = "Šema", Platform = "Ivan" },
                new Command { Id = 2, HowTo = "Radi", Line = "Ne pada", Platform = "Ne raste" }
                };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Kako", Line = "La Linea", Platform = "Zvezdica" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
