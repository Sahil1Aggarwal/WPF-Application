using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace LAB3._1 // name of my namespace 
{
    public partial class MainWindow : Window
    {
        // Various Combo names
        private ObservableCollection<Food> beverage = new ObservableCollection<Food>();
        private ObservableCollection<Food> mainCourse = new ObservableCollection<Food>();
        private ObservableCollection<Food> appetizer = new ObservableCollection<Food>();
        private ObservableCollection<Food> dessert = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodList = new ObservableCollection<Food>();
        int foodCount;
        double sum;
        string sub, tax = "13%", total; // Tax is considered to be 13%

        public MainWindow()  // Constructor 
        {
            InitializeComponent();
            LoadCollectionData();
            // Set item sources for ComboBoxes and DataGrid
            cbBeverage.ItemsSource = beverage;
            cbMainCourse.ItemsSource = mainCourse;
            cbAppetizer.ItemsSource = appetizer;
            cbDessert.ItemsSource = dessert;
            myBill.ItemsSource = foodList;
            foodCount = 0;
            DataContext = this;
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e) // Event handler for hyperlink navigation
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        private void LoadCollectionData() //Load data into different food categories which includes ID, name, category, price
        {
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 1,
                Name = "Soda",
                Category = "Beverage",
                Price = 1.95
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 2,
                Name = "Tea",
                Category = "Beverage",
                Price = 1.50
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 3,
                Name = "Coffee",
                Category = "Beverage",
                Price = 1.25
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 4,
                Name = "Mineral Water",
                Category = "Beverage",
                Price = 2.95
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 5,
                Name = "Juice",
                Category = "Beverage",
                Price = 2.50
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 6,
                Name = "Milk",
                Category = "Beverage",
                Price = 1.50
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 7,
                Name = "Buffalo Wings",
                Category = "Appetizer",
                Price = 5.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 8,
                Name = "Buffalo Fingers",
                Category = "Appetizer",
                Price = 6.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 9,
                Name = "Potato Skins",
                Category = "Appetizer",
                Price = 8.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 10,
                Name = "Nachos",
                Category = "Appetizer",
                Price = 8.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 11,
                Name = "Mushroom Caps",
                Category = "Appetizer",
                Price = 10.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 12,
                Name = "Shrimp Cocktail",
                Category = "Appetizer",
                Price = 12.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 13,
                Name = "Chips and Salsa",
                Category = "Appetizer",
                Price = 6.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 14,
                Name = "Seafood Alfredo",
                Category = "Main Course",
                Price = 15.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 15,
                Name = "Chicken Alfredo",
                Category = "Main Course",
                Price = 13.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 16,
                Name = "Turkey Club",
                Category = "Main Course",
                Price = 11.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 17,
                Name = "Lobster Pie",
                Category = "Main Course",
                Price = 19.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 18,
                Name = "Prime Rib",
                Category = "Main Course",
                Price = 20.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 19,
                Name = "Shrimp Scampi",
                Category = "Main Course",
                Price = 18.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 20,
                Name = "Turkey Dinner",
                Category = "Main Course",
                Price = 13.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 21,
                Name = "Stuffed Chicken",
                Category = "Main Course",
                Price = 14.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 22,
                Name = "Apple Pie",
                Category = "Dessert",
                Price = 5.95
            });

            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 23,
                Name = "Sundae",
                Category = "Dessert",
                Price = 3.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 24,
                Name = "Carrot Cake",
                Category = "Dessert",
                Price = 5.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 25,
                Name = "Mud Pie",
                Category = "Dessert",
                Price = 4.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 26,
                Name = "Apple Crisp",
                Category = "Dessert",
                Price = 5.95
            });

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e) // Add all the items and submit 
        {

        }

        private void BtnClearItem_Click(object sender, RoutedEventArgs e)
        {
            // Remove the selected item from the DataGrid
            if (myBill.SelectedIndex == -1) { MessageBox.Show("Please select the item"); }
            else { foodList.RemoveAt(myBill.SelectedIndex); }
        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        // Event handler for ComboBox selection changed and also adds or updates items in the DataGrid based on ComboBox selections
        {
            var selected = sender as ComboBox;
            bool added = false;
            if (selected.SelectedIndex.ToString() == "-1" || Int32.Parse(selected.SelectedIndex.ToString()) == 0)
            {

            }
            else
            {
                Food food1 = selected.SelectedValue as Food;
                if (foodList.Count() == 0)
                {
                    foodList.Add(food1);
                }
                else
                {

                    for (int i = 0; i < foodList.Count(); i++)
                    {
                        if (foodList[i].ID == food1.ID)
                        {
                            foodCount = foodCount + 1;
                            foodList.Remove(foodList[i]);
                            foodList.Add(new Food()
                            {
                                ID = food1.ID,
                                Category = food1.Category,
                                Name = food1.Name,
                                Quantity = foodCount,
                                Price = food1.Price
                            });
                            added = true;
                            break;
                        }
                    }
                    if (!added)
                    {
                        foodList.Add(food1);
                    }

                }
            }
            billSum();  // Update the subtotal, tax, and total

            Action a = () => selected.Text = "Default Text";
            Dispatcher.BeginInvoke(a);
        }

        private void billSum() // Calculates sum of total prices of selected items in the DataGrid and updates the Subtotal, Tax, and Total text boxes
        {
            sum = 0.0;
            foreach (Food food in foodList)
            {
                sum += food.TotalPrice;
            }
            sub = sum.ToString("C2", CultureInfo.CurrentCulture);
            tbSubtotal.Text = sub;
            total = (sum * 1.15).ToString("C2", CultureInfo.CurrentCulture);
            tbTotal.Text = total;
        }

        private void BtnClearBill_Click(object sender, RoutedEventArgs e) // Event handler for the "Clear Bill" button
        {
            foodList.Clear(); // Clear all the bill
        }

        private void MyBill_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) // Updates the quantity of an item in the DataGrid when edited
        {
            TextBox tbx = e.EditingElement as TextBox;

            DataGridRow row = e.Row;
            int index = row.GetIndex();
            DataGridColumn column = e.Column;
            int col = column.DisplayIndex;

            TextBlock x = myBill.Columns[0].GetCellContent(myBill.Items[index]) as TextBlock;
            foodCount = Int32.Parse(x.Text);
            foreach (Food food in foodList)
            {
                if (food.ID == Int32.Parse(x.Text))
                {
                    foodList.Remove(food);
                    foodList.Add(new Food()
                    {
                        ID = food.ID,
                        Category = food.Category,
                        Name = food.Name,
                        Quantity = Int32.Parse(tbx.Text),
                        Price = food.Price
                    });
                    billSum();
                    break;
                }
            }

        }

        private void myBill_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnLink_Click(object sender, RoutedEventArgs e) // Event handler for the "Click" button
        {
            MessageBox.Show("Clicked");
        }
        private void btnExport_Click(object sender, RoutedEventArgs e)  // Event handler for the "Export" button and exports the current bill details to a CSV file
        {
            try
            {
                using (var writer = new StreamWriter(@"CSV.csv"))
                {
                    foreach (var food in foodList)
                    {
                        var line = $"{food.Name},{food.Quantity},{food.Price},{food.CalculatedTotalPrice}";
                        writer.WriteLine(line);
                    }

                    writer.WriteLine($"Subtotal,,{sub}");
                    writer.WriteLine($"Tax,,{tax}");
                    writer.WriteLine($"Total,,{total}");
                }

                MessageBox.Show("Exported invoice to CSV.csv"); // Message is displayed 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // If any error then it is displayed here 
            }
        }


    }
}
