using System;

namespace Homework5
{
    class Program
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("菜单");
            Console.WriteLine("1. 添加");
            Console.WriteLine("2. 修改");
            Console.WriteLine("3. 删除");
            Console.WriteLine("4. 查询");
            Console.WriteLine("0. 退出");
        }
        public static void DisplayAddMenu()
        {
            Console.WriteLine("菜单：添加");
            Console.WriteLine("1. 添加货物");
            Console.WriteLine("2. 添加用户");
            Console.WriteLine("3. 添加订单");
            Console.WriteLine("0. 返回上一级");
        }

        public static void DisplayModifyMenu()
        {
            Console.WriteLine("菜单：修改");
            Console.WriteLine("1. 修改货物");
            Console.WriteLine("2. 修改用户");
            Console.WriteLine("3. 修改订单");
            Console.WriteLine("0. 返回上一级");
        }

        public static void DisplayRemoveMenu()
        {
            Console.WriteLine("菜单：删除");
            Console.WriteLine("1. 删除货物");
            Console.WriteLine("2. 删除用户");
            Console.WriteLine("3. 删除订单");
            Console.WriteLine("0. 返回上一级");
        }

        public static void DisplayQueryMenu()
        {
            Console.WriteLine("菜单：查询");
            Console.WriteLine("1. 按客户姓名查询订单");
            Console.WriteLine("2. 按时间查询订单");
            Console.WriteLine("3. 按ID查询订单");
            Console.WriteLine("4. 按自定义价格订单");
            Console.WriteLine("5. 按自定义时间订单");
            Console.WriteLine("6. 按ID序输出订单");
            Console.WriteLine("7. 按时间序输出订单");
            Console.WriteLine("8. 按价格序输出订单");
            Console.WriteLine("0. 返回上一级");
        }

        public static void Menu(int i,OrderService os)
        {
            try
            {
                bool flag = true;
                int option;
                switch (i)
                {
                    case 1:
                        while (flag)
                        {
                            DisplayAddMenu();
                            Int32.TryParse(Console.ReadLine(), out option);
                            AddMenu(option, os, ref flag);
                        }
                        break;
                    case 2:
                        while (flag)
                        {
                            DisplayModifyMenu();
                            Int32.TryParse(Console.ReadLine(), out option);
                            ModifyMenu(option, os, ref flag);
                        }
                        break;
                    case 3:
                        while (flag)
                        {
                            DisplayRemoveMenu();
                            Int32.TryParse(Console.ReadLine(), out option);
                            RemoveMenu(option, os, ref flag);
                        }
                        break;
                    case 4:
                        while (flag)
                        {
                            DisplayQueryMenu();
                            Int32.TryParse(Console.ReadLine(), out option);
                            QueryMenu(option, os, ref flag);
                        }
                        break;
                    default:
                        throw new Exception("菜单中无此项");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
        }

        public static void AddMenu(int i, OrderService os, ref bool flag)
        {
            try
            {
                string[] str;
                switch (i)
                {
                    case 1:
                        Console.WriteLine("输入货物信息：（类型 单价）");
                        str = Console.ReadLine().Split(' ', 2);
                        float.TryParse(str[1], out float price);
                        os.CreateGoods(str[0], price);
                        break;
                    case 2:
                        Console.WriteLine("输入用户信息：（姓名 地址）");
                        str = Console.ReadLine().Split(' ', 2);
                        os.CreateCustomer(str[0], str[1]);
                        break;
                    case 3:
                        Console.WriteLine("输入订单信息：（请选择下单客户的序号）");
                        os.DisplayCustomers();
                        Int32.TryParse(Console.ReadLine(), out int num);
                        os.CreateOrder(os.GetCustomer(num));
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("菜单中无此项");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
        }

        public static void ModifyMenu(int i, OrderService os, ref bool flag)
        {
            try
            {
                bool flag_order = true;
                string[] str;
                switch (i)
                {
                    case 1:
                        os.DisplayGoodses();
                        Console.WriteLine("请输入要修改的货物及其信息：（序号 名称 价格）");
                        str = Console.ReadLine().Split(' ', 3);
                        Int32.TryParse(str[0], out int num_goods);
                        float.TryParse(str[2], out float price);
                        os.ModifyGoods(num_goods,str[1],price);
                        break;
                    case 2:
                        os.DisplayCustomers();
                        Console.WriteLine("请输入要修改的客户及其信息：（序号 姓名 地址）");
                        str = Console.ReadLine().Split(' ', 3);
                        Int32.TryParse(str[0], out int num_customer);
                        os.ModifyCustomer(num_customer, str[1], str[2]);
                        break;
                    case 3:
                        while (flag_order)
                        {
                            os.DisplayOrders();
                            Console.WriteLine("请输入要修改的订单序号");
                            Int32.TryParse(Console.ReadLine(), out int num_order);
                            ModifyOrderMenu(num_order, os, ref flag_order);
                        }
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("菜单中无此项");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
        }

        public static void DisplayModifyOrderMenu()
        {
            Console.WriteLine("菜单：修改-订单");
            Console.WriteLine("1. 增加订单明细");
            Console.WriteLine("2. 修改订单明细");
            Console.WriteLine("3. 删除订单明细");
            Console.WriteLine("0. 返回上一级");
        }


        public static void ModifyOrderMenu(int num, OrderService os, ref bool flag)
        {
            DisplayModifyOrderMenu();
            string[] str;
            Int32.TryParse(Console.ReadLine(), out int i);
            switch (i)
            {
                case 1:
                    os.DisplayGoodses();
                    Console.WriteLine("选择货物及其数量：（序号 数量）");
                    str = Console.ReadLine().Split(' ', 2);
                    Int32.TryParse(str[0], out int goods_1);
                    Int32.TryParse(str[1], out int num_1);
                    os.GetOrder(num).Add(os.GetGoods(goods_1), num_1);
                    break;
                case 2:
                    os.GetOrder(num).DisplayOrderDetail();
                    Console.WriteLine("选择要修改的订单明细项及其货物数量：（序号 数量）");
                    str = Console.ReadLine().Split(' ', 2);
                    Int32.TryParse(str[0], out int orderDetail_2);
                    Int32.TryParse(str[1], out int num_2);
                    os.GetOrder(num).Modify(orderDetail_2, num_2);
                    break;
                case 3:
                    os.GetOrder(num).DisplayOrderDetail();
                    Console.WriteLine("选择要删除的订单明细项序号");
                    Int32.TryParse(Console.ReadLine(), out int num_3);
                    os.GetOrder(num).Remove(num_3);
                    break;
                case 0:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("菜单中无此项");
                    break;
            }
        }

        public static void RemoveMenu(int i, OrderService os, ref bool flag)
        {
            switch (i)
            {
                case 1:
                    os.DisplayGoodses();
                    Console.WriteLine("选择要删除的货物序号");
                    Int32.TryParse(Console.ReadLine(), out int num_goods);
                    os.RemoveGoods(num_goods);
                    break;
                case 2:
                    os.DisplayCustomers();
                    Console.WriteLine("选择要删除的用户序号");
                    Int32.TryParse(Console.ReadLine(), out int num_customer);
                    os.RemoveCustomer(num_customer);
                    break;
                case 3:
                    os.DisplayOrders();
                    Console.WriteLine("选择要删除的订单序号");
                    Int32.TryParse(Console.ReadLine(), out int num_order);
                    os.RemoveOrder(num_order);
                    break;
                case 0:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("菜单中无此项");
                    break;
            }
        }

        public static void QueryMenu(int i, OrderService os, ref bool flag)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("输入客户姓名：");
                    os.DisplayOrders(os.QueryByName(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("输入订单时间");
                    DateTime.TryParse(Console.ReadLine(), out DateTime time);
                    os.DisplayOrders(os.QueryByOrderTime(time));
                    break;
                case 3:
                    Console.WriteLine("输入订单ID：");
                    Int32.TryParse(Console.ReadLine(), out int id);
                    os.DisplayOrders(os.QueryByID(id));
                    break;
                case 4:
                    Console.WriteLine("输入查询条件：（例如： >10 <10 =10）");
                    string input_price = Console.ReadLine();
                    float.TryParse(input_price.Substring(1, input_price.Length - 1), out float price);
                    switch (input_price[0])
                    {
                        case '>':
                            os.DisplayOrders(os.QueryByCertainPrice(x => x > price));
                            break;
                        case '<':
                            os.DisplayOrders(os.QueryByCertainPrice(x => x < price));
                            break;
                        case '=':
                            os.DisplayOrders(os.QueryByCertainPrice(x => x == price));
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("输入查询条件：（例如： >2009-05-01 14:57:32.8）");
                    string input_time = Console.ReadLine();
                    DateTime.TryParse(input_time.Substring(1, input_time.Length - 1), out DateTime certainTime);
                    switch (input_time[0])
                    {
                        case '>':
                            os.DisplayOrders(os.QueryByCertainTime(x => x > certainTime));
                            break;
                        case '<':
                            os.DisplayOrders(os.QueryByCertainTime(x => x < certainTime));
                            break;
                        case '=':
                            os.DisplayOrders(os.QueryByCertainTime(x => x == certainTime));
                            break;
                    }
                    break;
                case 6:
                    os.DisplayOrders(os.OrderByID(os.GetOrders()));
                    break;
                case 7:
                    os.DisplayOrders(os.OrderByTime(os.GetOrders()));
                    break;
                case 8:
                    os.DisplayOrders(os.OrderByPrice(os.GetOrders()));
                    break;
                case 0:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("菜单中无此项");
                    break;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                OrderService os = new OrderService();
                while (true)
                {
                    DisplayMenu();
                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 0)
                        break;
                    Menu(option, os);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }

        }
    }
}
