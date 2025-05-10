namespace SwordAndSandals
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            Form1 form = new Form1();
            Image torsoImage = Image.FromFile(Path.GetFullPath(@"..\..\..\Assets\PNG\Shirts\Red\redShirt1.png"));
            Image headImage = Image.FromFile(Path.GetFullPath(@"..\..\..\Assets\PNG\Face\Completes\face1.png"));
            Image leftLegImage = Image.FromFile(Path.GetFullPath(@"..\..\..\Assets\PNG\Shirts\Red\redShirt1.png"));
            Image rightLegImage = Image.FromFile(Path.GetFullPath(@"..\..\..\Assets\PNG\Shirts\Red\redShirt1.png"));

            form.Paint += (o,e) =>
            {
                //e.Graphics.DrawImage(torsoImage, 100, 100);
                e.Graphics.DrawImage(headImage, 100, 80); // wy¿ej
                //e.Graphics.DrawImage(leftLegImage, 95, 140);
                //e.Graphics.DrawImage(rightLegImage, 105, 140);

            };




           
            Application.Run(form);
        }
    }
}