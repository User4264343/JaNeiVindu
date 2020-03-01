using System.Windows.Forms;

namespace JaNeiVindu
{
    public class Class1
    {
        /// <summary>
        /// Åpner et vindu med knappene Ja og Nei, og returnerer true hvis ja.
        /// </summary>
        /// <param name="tekst">Beskrivende tekst til vinduet.</param>
        /// <returns>true hvis ja.</returns>
        public bool JaNei(string tekst)
        {
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            JaNeiForm form = new JaNeiForm(tekst);
            form.ShowDialog();
            return form.ja;
        }
    }
}