using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomButton();

        }

        private void CustomButton()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox chatbotIcon = new PictureBox
            {
                Size = new Size(50, 50),
                Image = Image.FromFile("chatbot_icon.png"),  // Đường dẫn tới biểu tượng
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(this.Width - 60, this.Height - 60),  // Vị trí ở góc dưới phải
                Cursor = Cursors.Hand
            };
            chatbotIcon.Click += (s, e) => { OpenChatbot(); };
            this.Controls.Add(chatbotIcon);

        }
        private void OpenChatbot()
        {
            // Tạo một cửa sổ mới cho chatbot
            Form chatWindow = new Form
            {
                Text = "Chatbot Thông báo",
                Size = new Size(300, 400),
                StartPosition = FormStartPosition.CenterParent
            };

            // Tạo và cấu hình TextBox chatBox
            TextBox chatBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Size = new Size(280, 300),
                Location = new Point(10, 10),
                ScrollBars = ScrollBars.Vertical  // Thêm thanh cuộn nếu cần
            };

            // Tạo ô nhập liệu
            TextBox inputBox = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(10, 320)
            };

            // Tạo nút gửi
            Button sendButton = new Button
            {
                Text = "Gửi",
                Size = new Size(70, 30),
                Location = new Point(220, 320)
            };

            // Sự kiện khi nhấn nút gửi
            sendButton.Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(inputBox.Text)) // Kiểm tra không rỗng
                {
                    chatBox.AppendText("Người dùng: " + inputBox.Text + "\r\n");
                    inputBox.Clear(); // Xóa nội dung ô nhập
                }
            };

            // Thêm tất cả các control vào chatWindow
            chatWindow.Controls.Add(chatBox);
            chatWindow.Controls.Add(inputBox);
            chatWindow.Controls.Add(sendButton);
        };
    }
}
