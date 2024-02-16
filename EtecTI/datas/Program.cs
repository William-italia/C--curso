using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
                
        {
            Console.WriteLine("");


            DateTime agOra = DateTime.Now;
            DateTime torresGemeas = new DateTime(2001, 9, 11, 8, 46, 0);
            Console.WriteLine(agOra);
            Console.WriteLine(torresGemeas);

            Console.WriteLine("");

            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Year);
            Console.WriteLine(agora.Hour);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);
            Console.WriteLine(agora.Millisecond);
            Console.WriteLine(agora.Date);
            Console.WriteLine(agora.TimeOfDay);
            Console.WriteLine(agora.DayOfWeek);
            Console.WriteLine(agora.DayOfYear);

            Console.WriteLine("");

            DateTime hj = DateTime.Now;
            Console.WriteLine(hj.IsDaylightSavingTime());
            Console.WriteLine(DateTime.DaysInMonth(2021, 7));
            Console.WriteLine(DateTime.IsLeapYear(1988));

            Console.WriteLine("");

            DateTime hj01 = DateTime.Now;
            Console.WriteLine(hj01.ToShortDateString());
            Console.WriteLine(hj01.ToShortTimeString());

            Console.WriteLine("");

            DateTime Agora = DateTime.Now;
            DateTime Amanha = DateTime.Today.AddDays(1);
            Console.WriteLine(Agora);
            Console.WriteLine(Amanha);
            Console.WriteLine(DateTime.Compare(agora, Amanha));
            Console.WriteLine(DateTime.Compare(Amanha, Agora));

            Console.WriteLine("");

            DateTime agr = DateTime.Now;
            DateTime ftr = DateTime.Today.AddDays(1);
            Console.WriteLine(agr == ftr);
            Console.WriteLine(ftr >= agr);

            Console.WriteLine("");

            DateTime Agr = DateTime.Now;
            DateTime diaS = DateTime.Today.AddDays(1);
            TimeSpan intervalo = Agr - diaS;
            TimeSpan cinMAIStrinta = new TimeSpan(55, 30, 0);
            Console.WriteLine(Agr);
            Console.WriteLine(diaS);
            Console.WriteLine(intervalo);
            Console.WriteLine(cinMAIStrinta);
            Console.WriteLine(Agr + cinMAIStrinta);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Obtendo a data do sistema
            Console.WriteLine("");
            Console.WriteLine("---Obtendo a data do sistema");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            DateTime horaSistema = DateTime.Now;
            Console.WriteLine(horaSistema);
            //Inicialização uma data especifica
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine("---iNICIALIZAÇÃO");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            DateTime decolagem = new DateTime(1969, 7, 16, 13, 32, 00);
            DateTime pouso = new DateTime(1969, 7, 20, 20, 17, 17);
            String stringPouso = "20/07/1969 20:17:17";
            DateTime primeiroPouso = Convert.ToDateTime(stringPouso);
            Console.WriteLine($"(String)Decolagem Apollo 11..: {decolagem}");
            Console.WriteLine($"(String)Pouso na Lua.........: {stringPouso}");
            Console.WriteLine("");
            Console.WriteLine($"Decolagem Apollo 11..: {decolagem}");
            Console.WriteLine($"Pouso na Lua.........: {pouso}");

            Console.WriteLine("");

            //Exibindo data/hora, curta e longa
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---Data/Hora Longa e curta");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            String datalonga = horaSistema.ToLongDateString();
            String horalonga =horaSistema.ToLongTimeString();
            Console.WriteLine("");
            String datacurta = horaSistema.ToShortDateString();
            String horacurta = horaSistema.ToShortTimeString();
            Console.WriteLine($"Data longa: {datalonga}");
            Console.WriteLine($"Hora longa: {horalonga}");
            Console.WriteLine($"Data curta: {datacurta}");
            Console.WriteLine($"Hora curta: {horacurta}");
            
            Console.WriteLine("");

            //Obtendo partes de uma data
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("---Obtendo partes de uma data");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            int ano = horaSistema.Year;
            DateTime datasemhora= horaSistema.Date;
            int diadasemana = Convert.ToInt32(horaSistema.DayOfWeek);
            string diadasemanatexto = horaSistema.ToString("dddd");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Data sem hora: {datasemhora}");
            //Console.WriteLine($"Dia da semana: {diadasemana}");
            //Console.WriteLine($"Dia da semana: {diadasemanatexto}");
            Console.WriteLine($"Dia da semana: {diadasemana} => {diadasemanatexto}");
            
            Console.WriteLine("");

            //Alterando uma data
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---Alterando uma data");
            Console.ForegroundColor = ConsoleColor.Gray;
            DateTime vencimento = horaSistema.AddMonths(2).AddDays(-1).Date;
            DateTime horasAtras = horaSistema.AddHours(-5);
            Console.WriteLine($"Data: {horaSistema.Date}");
            Console.WriteLine($"vencimento: {vencimento}");
            Console.WriteLine($"hora: {horaSistema.TimeOfDay}");
            Console.WriteLine($"Horas atrás: {horasAtras.TimeOfDay}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Intervalos de tempo fixos
            Console.WriteLine("---Intervalos de tempo fixo");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            TimeSpan Doisdias = new TimeSpan(48, 0, 0);
            DateTime daquialgunsdias = horaSistema + Doisdias;
            Console.WriteLine($"Hora atual: {horaSistema}");
            Console.WriteLine($"Daqui dois dias: {daquialgunsdias}");

            Console.WriteLine("");

            //Calculando o intervalo entre duas datas
            Console.WriteLine("---Calculando o intervalo entre duas datas");
            Console.WriteLine("");
            DateTime horasystem = DateTime.Now;
            DateTime harasystemM = new DateTime(2123, 3, 3, 12, 0, 0);
            TimeSpan intervalo0 = harasystemM.TimeOfDay;
            int horasdecorridas = intervalo0.Hours; 
            TimeSpan tempodeviagem = primeiroPouso - decolagem;
            int diasdecorridos = tempodeviagem.Days;
            Console.WriteLine($"A primeira viagem a lua levou: {diasdecorridos} dias");
            Console.WriteLine($"Horas desde 0h: {horasdecorridas} horas");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();



        }
    }
}
