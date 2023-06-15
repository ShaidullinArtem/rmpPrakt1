using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rmpPract1._3.types;

namespace rmpPract1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Playlist myPlayList = new Playlist();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string content = myPlayList.getAllSongs();
                content += $"\nСейчас играет: {myPlayList.currentSong()}";
                songs_label.Text = content;
            }
            catch (Exception exception)
            {
                response_label.Text = exception.Message;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            string title = song_title_box.Text;
            string author = song_author_box.Text;
            string filename = song_flename_box.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(filename)) MessageBox.Show("Введите все данные");
            else
            {
                Song song = new Song();
                song.Title = title;
                song.Author = author;
                song.Filename = filename;
                myPlayList.addSong(song);
                
                string content = myPlayList.getAllSongs();
                content += $"\nСейчас играет: {myPlayList.currentSong().Title} ({myPlayList.currentSong().Author})";
                songs_label.Text = content;
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            myPlayList.nextSong();
            string content = myPlayList.getAllSongs();
            content += $"\nСейчас играет: {myPlayList.currentSong().Title} ({myPlayList.currentSong().Author})";
            songs_label.Text = content;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            myPlayList.backSong();
            string content = myPlayList.getAllSongs();
            content += $"\nСейчас играет: {myPlayList.currentSong().Title} ({myPlayList.currentSong().Author})";

            songs_label.Text = content;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            myPlayList.clearPlaylist();
            songs_label.Text = "";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            string title = song_remove_box.Text;

            if (string.IsNullOrWhiteSpace(title)) MessageBox.Show("Введите все данные");
            else
            {
                try
                {
                    string response = myPlayList.removeSong(title);
                    response_label.Text = response;
                    string content = myPlayList.getAllSongs();
                    content += $"\nСейчас играет: {myPlayList.currentSong().Title} ({myPlayList.currentSong().Author})";

                    songs_label.Text = content;
                }
                catch (Exception exception)
                {
                    songs_label.Text = "";
                    response_label.Text = exception.Message;
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            myPlayList.refresh();
            string content = myPlayList.getAllSongs();
            content += $"\nСейчас играет: {myPlayList.currentSong().Title} ({myPlayList.currentSong().Author})";

            songs_label.Text = content;
        }
    }
}