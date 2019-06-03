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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для Lexema.xaml
    /// </summary>
    public partial class Lexema : Page
    {
        public Lexema()
        {
            InitializeComponent();
        }
        int P;
        string Lexema_;
        string Lex;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Put(tb_lex);
            if (RIdent())
            {
                MessageBox.Show("Идентификатор");
            }
            else
            {
                Put(tb_lex);
                if (RReal())
                {
                    MessageBox.Show("Дейсвительное число");
                }
                else
                {
                    Put(tb_lex);
                    if (RInt())
                    {
                        MessageBox.Show("Целое число со знаком");
                    }
                    else
                    {
                        Put(tb_lex);
                        if (RIntWS())
                        {
                            MessageBox.Show("Целое число без знака");
                        }
                        else
                        {
                            if (Assi())
                            {
                                MessageBox.Show("Правильная программа");
                            }
                            else
                            {
                                MessageBox.Show("Ошибка данных");
                            }
                        }
                    }
                }
            }
        }

        public bool Arr()
        {
            int P;
            string Lex_;
            Lex_ = Lexema_;
            P = Lex.IndexOf("end.");
            if (Lexema_.Length > 0)
            {
                if (Lexema_[2] >= 'a' && Lexema_[2] <= 'z' || Lexema_[2] >= '0' && Lexema_[2] <= '9' || Lexema_[2] == '_')
                {
                    Lexema_ = Lexema_.Remove(2, 1);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool Assi()
        {
            Lex = Lexema_;
            if (Lex.Length > 0)
            {
                P = Lex.IndexOf("program");
                if (P >= 0)
                {
                    Lex.Remove(0, 8);
                    P = Lex.IndexOf(";");
                    if (P > 0)
                    {
                        Lexema_ = Lex.Substring(0, P-2);
                        if (RIdent())
                        {
                            if (Lex.Substring(P+1, 5) == "begin")
                            {
                                if (Lex.IndexOf("end.") >= 0)
                                {
                                    return true;
                                }
                                else return false;
                            }
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            return false;
        }

        public bool Put(TextBox tb)
        {
            Lexema_ = tb.Text;
            return true;
        }

        public bool RIdent()
        {
            if (Lexema_.Length > 1)
            {
                if (Lexema_[1] >= 'a' && Lexema_[1] <= 'z' || Lexema_[1] >= '0' && Lexema_[1] <= '9' || Lexema_[1] == '_')
                {
                    Lexema_ = Lexema_.Remove(1, 1);
                    return RIdent();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Lexema_[0] >= 'a' && Lexema_[0] <= 'z')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool RInt()
        {
            if (Lexema_[0] == '+' || Lexema_[0] == '-')
            {
                Lexema_ = Lexema_.Remove(0, 1);
                return RIntWS();
            }
            else
            {
                return false;
            }
        }

            public bool RIntWS()
            {
                if (Lexema_.Length > 0)
                {
                    if (Lexema_[0] >= '0' && Lexema_[0] <= '9')
                    {
                        Lexema_ = Lexema_.Remove(0, 1);
                        return RIntWS();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

        public bool RReal()
        {
            if (Lexema_.IndexOf(".") > 0) {
                string tmp = Lexema_;
                Lexema_ = Lexema_.Substring(0, Lexema_.IndexOf(".") - 1);
            if (Lexema_.Length > 0)
            {
                if (RInt() || RIntWS())
                {
                    Lexema_ = tmp.Substring((tmp.IndexOf(".")+1), (tmp.Length - tmp.IndexOf(".")-1));
                    return RIntWS();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
            else
            {
                return false;
            }
            }
        }
    }
