using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SYNCCART
{
    public class Operations
    {
        List<CustomerDetails> Customers = new List<CustomerDetails>();
        List<OrderDetails> Orders = new();
        List<ProductDetails> Products = new();
        CustomerDetails currentCustomer;

        public void DefaultData()
        {
            Console.WriteLine("Default values");

            CustomerDetails customer = new("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com");
            CustomerDetails customer1 = new("Baskaran", "Chennai", 9888475757, 60000, "baskaran@mail.com");
            Customers.AddRange(new List<CustomerDetails>() { customer, customer1 });

            OrderDetails order = new("CID3001", "PID2001", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            OrderDetails order1 = new("CID3002", "PID2003", 40000, DateTime.Now, 2, OrderStatus.Ordered);
            Orders.AddRange(new List<OrderDetails>() { order, order1 });

            ProductDetails product1 = new("Mobile(Samsung)", 10, 10000, 3);
            ProductDetails product2 = new("Mobile (Samsung)", 10, 10000, 3);
            ProductDetails product3 = new("Camara (Sony)", 3, 20000, 4);
            ProductDetails product4 = new("iPhone", 5, 50000, 6);
            ProductDetails product5 = new("Laptop (Lenovo I3)", 3, 40000, 3);
            ProductDetails product6 = new("HeadPhone (Boat)", 5, 1000, 2);
            ProductDetails product7 = new("HeadPhone (Boat)", 5, 1000, 2);
            Products.AddRange(new List<ProductDetails>() { product1, product2, product3, product4, product5, product6, product7 });


            /*foreach (CustomerDetails customerData in Customers)
            {
                Console.WriteLine($"|{customerData.CustomerID,-15} | {customerData.CustomerName,-15} | {customerData.City,-15} | {customerData.MobileNumber,-15}|{customerData._balance,-15}|{customerData.Email,-15}");
            }
            foreach (OrderDetails orderDetail in Orders)
            {
                Console.WriteLine($"|{orderDetail.OrderID,-15} | {orderDetail.CustomerID,-15} | {orderDetail.ProductID,-15}| {orderDetail.TotalPrice,-15}| {orderDetail.PurchaseDate,-15}| {orderDetail.Quantity,-15}| {orderDetail.OrderStatus,-15}");
            }
            foreach (ProductDetails productData in Products)
            {
                Console.WriteLine($"|{productData.ProductID,-15} | {productData.ProductName,15} | {productData.Stock,-15} | {productData.Price,-15}|{productData.ShippingDuration}");
            }*/

        }

        public void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("***Main Menu***");
                Console.WriteLine("Select \n1.Registration\n2.Login\n3.Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                    default:
                    {
                        Console.WriteLine("Invalid option Please enter the correct one");
                        break;
                    }
                }
            } while (flag);
        }

        public void Registration()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number:");
            long phonenumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Balance:");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your MailID");
            string email = Console.ReadLine();

            CustomerDetails customer = new(name, city, phonenumber, balance, email);
            Console.WriteLine($"Your Registration was successful and your ID is  {customer.CustomerID}");
            Customers.Add(customer);

        }
        public void Login()
        {
            System.Console.WriteLine("User Login");
            Console.WriteLine("Enter your ID:");
            string customerID = Console.ReadLine();
            bool flag = true;
            foreach (CustomerDetails customer in Customers)
            {
                if (customerID.Equals(customer.CustomerID))
                {
                    Console.WriteLine("Login successful");
                    flag = false;
                    currentCustomer = customer;
                    SubMenu();
                    break;

                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }
        //SubMenu() method consists of methods like Purchase(),OrderHistory(),CancelOrder(),Balance(),Recharge() and exit()
        public void SubMenu()
        {
            bool flag = true;
            do
            {
                //action to be repeated
                System.Console.WriteLine("***SubMenu***");
                Console.WriteLine("Select option \n1.Purchase \n2.Order History \n3.Cancel Order \n4.Balance \n5.Recharge \n6.Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Purchase();
                            break;
                        }
                    case 2:
                        {
                            OrderHistory();
                            break;
                        }
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            Balance();
                            break;
                        }
                    case 5:
                        {
                            Recharge();
                            break;
                        }
                    case 6:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                    default:
                    {
                        Console.WriteLine("Invalid Choice.Please enter the correct one");
                        break;
                    }
                }
                //termination condition
            } while (flag);
        }
        //Purchase() method is used to purchase a product from the product list, it checks the productID ,and also wallet balance to purchase the item..
        public void Purchase()
        {
            System.Console.WriteLine("***Purchase***");
            //show list of products from product list
            foreach (ProductDetails product in Products)
            {
                Console.WriteLine($"|{product.ProductID,-15} |{product.ProductName,-15} |{product.Stock,-15} |{product.Price,-15} |{product.ShippingDuration,-15}");
            }
            //ask and get product id
            Console.WriteLine("Enter Product ID:");
            string productID = Console.ReadLine();
            //validate product id - if invalid show invalid product id
            bool flag = true;
            foreach (ProductDetails product in Products)
            {
                if (product.ProductID.Equals(productID))
                {
                    flag = false;
                    //if id is valid - ask and get required product count
                    Console.WriteLine("Enter the quantity you want:");
                    int quantity = int.Parse(Console.ReadLine());
                    //check product availability if quantity is not available then show Stock not available
                    if (product.Stock >= quantity)
                    {
                        //if quantity is available -calculate total price
                        double totalPrice = quantity * product.Price;
                        //check user wallet - check he has enough balance if not show in sufficient balance recharge and proceed through
                        //if he has balance the debut that product total price with his balance 
                        if (currentCustomer.WalletBalance >= totalPrice)
                        {
                            currentCustomer.DeductBalance(totalPrice);
                            //reduce stock count
                            product.Stock -= quantity;
                            //create order object and add it to the list
                            OrderDetails order = new(currentCustomer.CustomerID, product.ProductID, totalPrice, DateTime.Now, quantity, OrderStatus.Ordered);
                            Orders.Add(order);
                            Console.WriteLine($"Your order placed sucessfully{order.OrderID}");

                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                    }
                    else
                    {
                         Console.WriteLine("This product is not available Now");
                    }
                    break;
                }  
            }
            Console.WriteLine(flag ? "Invalid Product ID" : "");
        }
        public void CancelOrder()
        {
             // Traverse and show order history of current user whose order status is booked

             bool flag = true;
             foreach(OrderDetails order in Orders){
                if(order.CustomerID.Equals(currentCustomer.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                   flag = false;
                   Console.WriteLine($"|{order.OrderID,-15} | {order.CustomerID,-15} | {order.ProductID,-15}| {order.TotalPrice,-15}| {order.PurchaseDate,-15}| {order.Quantity,-15}| {order.OrderStatus,-15}");  
                   //validate if order id is present - if not show invalid order id
                   Console.WriteLine("Enter the OrderId you want to cancel:");
                   string orderID = Console.ReadLine();
                   bool flag1 = true;
                   foreach(OrderDetails order1 in Orders){
                      if(order1.OrderID.Equals(orderID) && order.OrderStatus.Equals(OrderStatus.Ordered)){
                          flag1 = false;
                          //if order id valid return the products in order list to product list
                          foreach(ProductDetails product in Products){
                                if(order1.ProductID.Equals(product.ProductID)){
                                    product.Stock+=order1.Quantity;
                                    currentCustomer.Recharge(order.TotalPrice);
                                    //change order status to cancel
                                    order1.OrderStatus=OrderStatus.Cancelled;
                                    Console.WriteLine("Order cancelled sucessfully...");
                                    break;
                                }

                          }
                          


                      }
                           
                   }
                   Console.WriteLine(flag1?"Invalid Order ID":" ");

                }
             }
              //if there is no order history - show no order history
             Console.WriteLine(flag?"Your have not placed any orders yet":" ");
           
            
            
           
           
            
            
        }
        public void OrderHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in Orders)
            {
                if (order.CustomerID.Equals(currentCustomer.CustomerID)){
                    flag=false;
                    Console.WriteLine($"|{order.OrderID,-15} | {order.CustomerID,-15} | {order.ProductID,-15}| {order.TotalPrice,-15}| {order.PurchaseDate,-15}| {order.Quantity,-15}| {order.OrderStatus,-15}");


                }
            }
            Console.WriteLine(flag?"You not placed any order till now":"");
        }
        public void Balance()
        {
            System.Console.WriteLine("*** Balance ****");
            Console.WriteLine("Your Ba5lance is" + currentCustomer.WalletBalance);
        }
        public void Recharge()
        {
            System.Console.WriteLine("***Recharge***");
            Console.WriteLine("Enter amount to be recharge");
            double amount = double.Parse(Console.ReadLine());
            currentCustomer._balance += amount;
        }
        

    }

}
