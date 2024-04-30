using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login.Telas
{
    /// <summary>
    /// Lógica interna para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DadosAluno dadosAluno = new DadosAluno();
            dadosAluno.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Escola escola = new Escola();
            escola.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Curso curso = new Curso();
            curso.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            VizuAluno vizuAluno = new VizuAluno();
            vizuAluno.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            VizuEscola visu = new VizuEscola();
            visu.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            VizuCurso curso = new VizuCurso();  
            curso.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            VizuTurma vizuTurma = new VizuTurma();
            vizuTurma.ShowDialog();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seus dados foram salvos!");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
