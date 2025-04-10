namespace CadastroAluno;

public partial class Form1 : Form
{
        private Panel loginPanel;
        private Panel registroPanel;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private PictureBox imagemLogo;

        public Form1()
        {
            InitializeComponent();
            CriarComponentes();
        }

        private void CriarComponentes()
        {
            // Painel de login
            loginPanel = new Panel();
            loginPanel.Size = new Size(300, 250);
            loginPanel.Location = new Point(10, 10);
            loginPanel.BackColor = Color.LightGray;

            // Painel de registro (só como exemplo, escondido por padrão)
            registroPanel = new Panel();
            registroPanel.Size = new Size(300, 250);
            registroPanel.Location = new Point(320, 10);
            registroPanel.BackColor = Color.LightBlue;
            registroPanel.Visible = false;

            // TextBox usuário
            txtUsuario = new TextBox();
            txtUsuario.Location = new Point(20, 30);
            txtUsuario.Width = 200;
            txtUsuario.PlaceholderText = "Usuário";

            // TextBox senha
            txtSenha = new TextBox();
            txtSenha.Location = new Point(20, 70);
            txtSenha.Width = 200;
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";

            // Botão Entrar
            btnEntrar = new Button();
            btnEntrar.Text = "Entrar";
            btnEntrar.Location = new Point(20, 110);
            btnEntrar.Click += BtnEntrar_Click;

            // PictureBox (logo ou imagem qualquer)
            imagemLogo = new PictureBox();
            imagemLogo.Size = new Size(100, 100);
            imagemLogo.Location = new Point(180, 130);
            imagemLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemLogo.Image = Image.FromFile("logo.png"); // imagem local (coloque na raiz do projeto)

            // Adicionando controles ao painel
            loginPanel.Controls.Add(txtUsuario);
            loginPanel.Controls.Add(txtSenha);
            loginPanel.Controls.Add(btnEntrar);
            loginPanel.Controls.Add(imagemLogo);

            // Adicionando painéis ao formulário
            Controls.Add(loginPanel);
            Controls.Add(registroPanel);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login clicado!");
        }
    }
