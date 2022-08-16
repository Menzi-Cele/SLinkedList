using MyKaraoke.CLinkedLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKaraoke
{
    /*
     * Menzi Cele
     * Lungelo Zungu
     * Fransua Somers
     * Terrel Rangasamy
     * Owethu Nxumalo
     * Reeselin
     * Thabo Gumbi
     */
    public partial class Form1 : Form
    {
        SLinkedList slinkedList = new SLinkedList();
        LinkedList<string> list = new LinkedList<string>();
        LinkedList<string> newlist = new LinkedList<string>();
        private SoundPlayer _soundPlayer;
        //struct Music
        //{
        //    public void PlaySong()
        //    {
        //        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //        player.SoundLocation = ;
        //        player.Load();
        //        player.Play();
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("MySong.wav");
            
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slinkedList.appendNode("Earth to sky, bwoy violate gyal Later, yo Bullet, shotta");
            slinkedList.appendNode("Ayy, Bun', who's that? Pree that That's shot bro, pass me the wap " +
                "Fuck that, I might blow out your girlfriend's back Only got one eye, you don't wanna lose that Keep - keep running your mouth, you're borin' Bros might run in your house, keep talkin'" +
                " Slap one out the zig, no warning " +
                "Spaceship, hear my engine roarin' (shotta) Fuck six gyal in a month, I'm whorin' 6:30, make her touch the floor(woo) " +
                "Play dirty, course I hit that raw(woo)I fucked her good, now, she want some more(woo)" +
                "Platinum plaques, but I still want moreThree top tens, but I soon have four" +
                "We don't care what you done before" +
                "Chat dem ah chat, dem man don't want war");
            slinkedList.applyProfanityFilter("Bullet");




            //slinkedList.appendNode("Earth to sky, bwoy violate gyal Later, yo Bullet, shotta");
            //slinkedList.appendNode("Ayy, Bun', who's that? Pree that That's shot bro, pass me the wap " +
            //    "Fuck that, I might blow out your girlfriend's back Only got one eye, you don't wanna lose that Keep - keep running your mouth, you're borin' Bros might run in your house, keep talkin'" +
            //    " Slap one out the zig, no warning " +
            //    "Spaceship, hear my engine roarin' (shotta) Fuck six gyal in a month, I'm whorin' 6:30, make her touch the floor(woo) " +
            //    "Play dirty, course I hit that raw(woo)I fucked her good, now, she want some more(woo)" +
            //    "Platinum plaques, but I still want moreThree top tens, but I soon have four" +
            //    "We don't care what you done before" +
            //    "Chat dem ah chat, dem man don't want war");

            foreach (var line in slinkedList.ToString())
            {

                richTextBox1.Text  += line;
            }
            _soundPlayer.Play();
            //Music music;

            //do
            //{
            //    music.PlaySong();
            //} while (true);
        }
    }
}
    

