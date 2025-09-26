using System;
using System.Windows.Forms;
using Proj._Lista___Agenda___WFA.Forms; // <- namespace correto do AgendaForm

namespace Proj._Lista___Agenda___WFA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aqui abrimos o AgendaForm
            Application.Run(new AgendaForm());
        }
    }
}
