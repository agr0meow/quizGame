using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 15;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
          
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Викторина окончена" + Environment.NewLine +
                                "Вы ответили на " + score + " вопрос(ов) правильно." + Environment.NewLine +
                                "Ваш общий процент составляет " + percentage + " %" + Environment.NewLine +
                                "Нажмите ок для повторной игры"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "По-настоящему рынок информационных ресурсов и услуг расцвёл после широкого внедрения:";

                    button1.Text = "Прессы";
                    button2.Text = "Микрокомпьютеров";
                    button3.Text = "Телевидения";
                    button4.Text = "Пропустить вопрос";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Важнейшим компонентом отечественного рынка информационных ресурсов являются данные:";

                    button1.Text = "О гражданах";
                    button2.Text = "Об информационном оборудовании";
                    button3.Text = "об экологии";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.halo4;

                    lblQuestion.Text = "Что такое информационная система ";

                    button1.Text = "Предназначенная для хранения, поиска и обработки информации, и соответствующие организационные ресурсы";
                    button2.Text = "Система контроля информацией ";
                    button3.Text = "Информация используемая только в интернете ";

                    correctAnswer = 1;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Что такое иерархия в информационной системе";

                    button1.Text = "Это модель данных, где используется представление базы данных в виде древовидной (иерархической) структуры, состоящей из объектов (данных) различных уровней.";
                    button2.Text = "Набор правил, созданный для контроля данных в системе";
                    button3.Text = "Система аналитической обработки в режиме реального времени";
                 

                    correctAnswer = 1;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.gears_of_war;

                    lblQuestion.Text = "Что такое программные модули в информационной системе";

                    button1.Text = "Функционально законченный фрагмент программы";
                    button2.Text = "Законченный фрагмент документа";
                    button3.Text = "Модуль позволяющий работать с табличными данными";
                

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "Принцип использования аппаратных и программных модулей ";

                    button1.Text = "Возможность поэтапного создания система";
                    button2.Text = "Принцип правильного написания документации ";
                    button3.Text = "Все перечисленное";

                    correctAnswer = 1;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.halo2;

                    lblQuestion.Text = "Что такое избыточность в информационных системах ";

                    button1.Text = "Избыточное количество текста";
                    button2.Text = "Лимит, на количество информации  ";
                    button3.Text = "Это информация, превышающая полную информацию и формально являющаяся лишней в сообщении";

                    correctAnswer = 3;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.halo3;

                    lblQuestion.Text = "К основным способам группирования информационных ресурсов относятся:";

                    button1.Text = "Значимость в обществе";
                    button2.Text = "Отраслевой принцип";
                    button3.Text = "Форма представления";

                    correctAnswer = 3;

                    break;
                case 9:

                    pictureBox1.Image = Properties.Resources.halo4;

                    lblQuestion.Text = "К информационным ресурсам относится такая форма принципов :";

                    button1.Text = "Главная";
                    button2.Text = "Дополнительная";
                    button3.Text = "Пассивная";

                    correctAnswer = 3;

                    break;
                case 10:

                    pictureBox1.Image = Properties.Resources.halo2;

                    lblQuestion.Text = "Что такое  научно-техническая информации:";

                    button1.Text = "Информация, используемая в сфере техники при решении производственных задач";
                    button2.Text = "Объединение научной и технической видов информации";
                    button3.Text = "Финансовая и экономическа информация";

                    correctAnswer = 2;

                    break;

                case 11:

                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "Что делают управляющие системы?";

                    button1.Text = "Вырабатывают информацию, которая принимается человеком к сведению и не превращается немедленно в серию конкретных действий";
                    button2.Text = "Выполняют инженерные расчеты, создают графическую документацию.";
                    button3.Text = "Вырабатывают информацию, на основании которой человек принимает решение";

                    correctAnswer = 3;

                    break;

                case 12:

                    pictureBox1.Image = Properties.Resources.halo4;

                    lblQuestion.Text = "Для чего предназначены информационные системы организационного управления?";

                    button1.Text = "Для автоматизации функций управленческого персонала";
                    button2.Text = "Для автоматизации любых функций компании и охватывают весь цикл работ от проектирования до сбыта продукции\r\nдля автоматизации функций производственного персонала";
                    button3.Text = "Финансовая и экономическа информация";

                    correctAnswer = 1;

                    break;

                case 13:

                    pictureBox1.Image = Properties.Resources.halo4;

                    lblQuestion.Text = "CASE-технологии – это";

                    button1.Text = "Совокупность информацию";
                    button2.Text = "Система показателей ";
                    button3.Text = "Методика, позволяющая конструировать ИС из стандартных модулей";

                    correctAnswer = 3;

                    break;

                case 14:

                    pictureBox1.Image = Properties.Resources.halo3;

                    lblQuestion.Text = "Что включает принцип доступности информации ";

                    button1.Text = "Состояние информации (ресурсов автоматизированной информационной системы), при котором субъекты, имеющие права доступа, могут реализовывать их беспрепятственно.";
                    button2.Text = "Доступ к любым источникам информации ";
                    button3.Text = "Все перечиленное";

                    correctAnswer = 3;

                    break;








            }




        }

    }
}
