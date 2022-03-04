using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace KZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string data = File.ReadAllText("../../../data.txt");
            var data = Data.Records;
            var employees = data
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Split(",", StringSplitOptions.RemoveEmptyEntries))
                .Select(a3 => new Employee($"{a3[0]} {a3[1]}", decimal.Parse(a3[2])))
                .ToList();

            var totalBefore = employees.Sum(x => x.Salary);
            Console.WriteLine($"Before change Total Cost: {totalBefore:F2} $.");
            Console.WriteLine(new String('=',20));
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //
            foreach (Employee emp in employees)
            {
                emp.Salary *= 1.1m;
            }
            //
            watch.Stop();
            Console.WriteLine($"Salary Increase was performed for : {watch.Elapsed.Minutes} minutes and {watch.Elapsed.Seconds} seconds");
            var totalAfter = employees.Sum(x => x.Salary);
            Console.WriteLine($"After change Total Cost: {totalAfter:F2} $.");
        }
    }

    public class Employee
    {
        private decimal _salary;
        public Employee(string name, decimal salary)
        {
            Name = name;
            _salary = salary;
        }

        public string Name { get; set; }
        public decimal Salary
        {
            get { return this._salary; }
            set
            {
                var before = _salary;
                System.Threading.Thread.Sleep(1000);
                this._salary = value;
                Console.WriteLine($"{this.Name} has changed salary from {before:F2} to {_salary:F2} $.");
            }
        }
    }

   static class Data
    {
        public static string Records { get; set; } = @"Salem,Honniebal,7307.17
Dorri,Pocknell,4544.27
Charil,Catcheside,3866.79
Dulci,Allberry,4204.22
Benoite,Alliband,8669.64
Aggie,Piniur,7100.38
Nikolaus,Konneke,4500.06
Patric,Saltsberg,7862.23
Shell,Witherby,8438.42
Mead,Griston,7974.52
Terrye,Hynd,7804.03
Dwain,Bertholin,8980.14
Jacquette,Jermyn,6733.21
Carolyn,Golborne,7663.76
Sandy,Fearenside,4801.81
Page,Bowles,9000.06
Pennie,Paterno,2825.32
Jammal,Folker,6192.04
Kendal,Borley,1278.16
Lorenzo,Hullah,5225.79
Orrin,Savaage,1767.88
Jory,Van der Hoven,7954.62
Tiena,Silk,5471.0
Wini,Visco,3618.13
Marquita,Hurren,6356.97
Tallou,Burnall,2146.14
Kenneth,Kondrat,9644.8
Mikey,Espinosa,6438.25
Estrellita,Duddell,3750.76
Gabbey,Cheston,7094.44
Annelise,Filipczynski,2684.62
Rodolfo,Toyer,5820.25
Emmalee,Adcock,3171.83
Pepe,Surmeir,1452.81
Maura,Lowy,7158.27
Warner,Batman,8651.7
Jerrold,Joerning,6452.97
Zack,Roofe,4938.51
Ginny,O' Sullivan,5376.09
Karel,Pietzner,3902.49
Sandye,Tarquinio,5277.99
Effie,Foxten,7691.14
Lowell,Jesper,7130.92
Gaile,Pyper,8127.42
Auria,Dyte,7443.42
Viv,Thouless,5821.89
Orella,Cogdell,7654.25
Benita,Morales,7287.94
Rosamund,Mowen,7634.73
Finn,O'Dulchonta,4217.29
Erminie,MacKeeg,4562.85
Nester,Culwen,3596.24
Donovan,Poytress,7382.68
Cary,Knoble,5779.92
Dulcia,Cawt,8022.61
Evangelina,Emeny,3989.12
Teodora,Follis,9747.07
Nettle,Sleite,8899.01
Edythe,Culpan,5453.89
Minnnie,Dupree,6833.25
Dasie,Petworth,4203.66
Emory,Swaden,3787.37
Guenevere,Scohier,7565.36
Bill,Frie,5610.5
Jethro,Balden,7764.5
Sharity,Roscow,3650.4
Zak,Tomaino,8990.66
John,Kinnane,9351.19
Sheree,Cullimore,7176.08
Elicia,Mitchelhill,2946.75
Clarance,Cooney,2016.36
Ermin,Edwardson,5318.88
Amabelle,Coole,5525.61
Domenic,Farnill,8032.45
Christen,Scalia,3715.88
Ferdinand,Arney,1515.25
Isidora,Prettejohns,7519.34
Jamima,Honnan,3773.83
Delila,McKinn,7511.73
Morrie,Burgoin,8370.81
Nicoline,Monsey,1700.07
Jordan,Yanez,1875.42
Barris,McCullogh,8399.62
Sargent,McCuaig,2010.11
Shelden,Sales,8775.35
Claude,Shelbourne,2577.18
Gillan,McCallion,6771.34
Consuelo,Ashfield,9398.05
Jenn,Dorsey,1793.12
Vernice,Giacopello,7517.63
Rriocard,Gelsthorpe,3352.64
Randolf,Woolf,5806.86
Irina,Greystock,2870.27
Bethena,Trippack,3519.92
Janina,Costerd,5291.29
Bernardine,Attwooll,7530.48
Oneida,Spadoni,3323.55
Gilberta,Annes,3358.17
Andonis,Seemmonds,9520.05
Samara,Callaby,9156.11";
    }


}