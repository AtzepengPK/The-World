using ConsoleApp4;
using ConsoleApp4.Core.Abstractions.Classes.Maps.Configurations;
using ConsoleApp4.Core.Abstractions.Natural;
using ConsoleApp4.Core.Implementations.Maps.Configurations;
using ConsoleApp4.Core.Intarfaces;
using ConsoleApp4.Core.Interfaces;
using ConsoleApp4.Core.Interfaces.Natural;
using ConsoleApp4.Implementations;
using ConsoleApp4.Implementations.Artificial;
using ConsoleApp4.Implementations.Artificial.TypeCell;
using ConsoleApp4.Implementations.Natural;
using ConsoleApp4.Implementations.Natural.TypeCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TheWorld.Core.Abstractions.Classes;
using TheWorld.Core.Abstractions.Interfaces;
using TheWorld.Core.Implementations;

namespace TheWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Default2DMap<Default2DMapConfiguration> map1 = new Default2DMap<Default2DMapConfiguration>();
        Default3DMap<Default3DMapConfiguration> map2 = new Default3DMap<Default3DMapConfiguration>();
        Popup popup;

        List<IHuman> workers = new List<IHuman>();

        public MainWindow()
        {
            InitializeComponent();

            //Map prova = new Map();

            //Tree albero = new Tree();
            //Water acqua = new Water();
            NaturalCell<Tree> tree = new NaturalCell<Tree>();
            NaturalCell<Water> water = new NaturalCell<Water>();
            ArtificialCell<House> house = new ArtificialCell<House>();
            popup = new Popup();

            

            workers.Add(new Human("gianni",10));
            workers.Add(new Human("pino", 12));

            //tree.WorkCell(workers);

            //prova.Add(tree);
            //prova.Add(house);
            //Console.WriteLine(prova[0].GetType());   


           

            //gianni.profession.


            newMap.Click += delegate { map1.CreateNewMap(); createCells(); assignButtons(); };
        }

        void createCells()
        {
            gridMap.RowDefinitions.Clear();
            gridMap.ColumnDefinitions.Clear();

            for (int i = 0; i < map1.Configuration.Height; i++)
            {
                gridMap.RowDefinitions.Add(new System.Windows.Controls.RowDefinition());
            }
            for (int i = 0; i < map1.Configuration.Width; i++)
            {
                gridMap.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition());
            }
        }
        void assignButtons()
        {
            for (int i = 0; i < gridMap.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < gridMap.ColumnDefinitions.Count; j++)
                {
                    Button btn = new Button();
                    btn.Width = 250;
                    btn.Height = 250;              

                    btn.Background = map1.Map[i, j] != null ? map1.Map[i, j].color : Brushes.White;
                    position pos = new position();
                    pos.x = i;
                    pos.y = j;

                    if (map1.Map[i, j] != null)
                        map1.Map[i, j].Position = pos;

                    btn.SetValue(Grid.RowProperty, i);
                    btn.SetValue(Grid.ColumnProperty, j);

                    btn.Click += delegate { Console.WriteLine("WORKING CELL x:" +  pos.x +" y:"+ pos.y);
                        map1.Map[pos.x, pos.y].WorkCell(workers);
                    };

                    gridMap.Children.Add(btn);
                }
            }
        }
    }
}
