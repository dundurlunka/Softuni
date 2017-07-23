using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite
{
    public class CommandParser
    {
        private List<ISoldier> soldiers;

        public CommandParser()
        {
            this.Soldiers = new List<ISoldier>();
        }

        public List<ISoldier> Soldiers { get => soldiers; set => soldiers = value; }

        public void Parse(string[] args)
        {
            var type = args[0];
            switch (type)
            {
                case "Private":
                    soldiers.Add(CreatePrivate(args));
                    break;
                case "LeutenantGeneral":
                    soldiers.Add(CreateLeutenantGeneral(args));
                    break;
                case "Engineer":
                    try
                    {
                        soldiers.Add(CreateEngineer(args));
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "Commando":
                    try
                    {
                        soldiers.Add(CreateCommando(args));
                    }
                    catch (Exception)
                    {
                    }                    
                    break;
                case "Spy":
                    soldiers.Add(CreateSpy(args));
                    break;
                default:
                    break;
            }
        }

        private Spy CreateSpy(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var codeNumber = int.Parse(args[4]);
            var spy = new Spy(id, firstName, lastName, codeNumber);

            return spy;
        }

        private Commando CreateCommando(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = double.Parse(args[4]);
            var corps = args[5];
            var commando = new Commando(id, firstName, lastName, salary, corps);

            for (int i = 6; i < args.Length; i+=2)
            {
                var missionCodeName = args[i];
                var missionState = args[i + 1];
                try
                {
                    var mission = new Mission(missionCodeName, missionState);
                    commando.Missions.Add(mission);
                }
                catch (Exception)
                {
                }
            }
            return commando;
        }

        private Engineer CreateEngineer(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = double.Parse(args[4]);
            var corps = args[5];
            var engineer = new Engineer(id, firstName, lastName, salary, corps);
            for (int i = 6; i < args.Length; i+=2)
            {
                var partName = args[i];
                var workedHours = int.Parse(args[i + 1]);
                var repair = new Repair(partName, workedHours);
                engineer.Repairs.Add(repair);
            }

            return engineer;
        }

        private LeutenantGeneral CreateLeutenantGeneral(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = double.Parse(args[4]);

            var leutenant = new LeutenantGeneral(id, firstName, lastName, salary);
            for (int i = 5; i < args.Length; i++)
            {
                var privateSoldier = this.Soldiers.Where(s => s.Id == int.Parse(args[i])).FirstOrDefault();
                leutenant.Privates.Add(privateSoldier);
            }
            return leutenant;
        }

        public static Private CreatePrivate(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = double.Parse(args[4]);
            var privateSoldier = new Private(id, firstName, lastName, salary);
            return privateSoldier;
        }
    }
}
