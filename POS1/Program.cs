using System;
class Program
{
    static void Main(string[] args)
    {
        // 1. Initialise a store database
        Store store = new Store();
        // 2. A staff member should be registered
        store.StaffDB.Add("admin", "admin", admin: true);
        // 3. Login with username and password
        if (store.StaffDB.Login("admin", "admin"))
        {
            // 3. A customer should be registered
            store.CustomerDB.Add(
                name: "Ted",
                surname: "Lasso",
                phone: "0498-123-123",
                address: "2 Fake St",
                email: "tedlasso@email.com",
                id: 1
            );
            // 4. Products should be registered
            store.ProductDB.Add(
                name: "Zelda",
                price: 105,
                quantity: 30
            );
            store.ProductDB.Add(
                name: "Mario",
                price: 80,
                quantity: 80
            );
            // 5. Sale executes - Ted buys two copies of Zelda for $210
            store.ExecuteSale(
                customerID: 1,
                productID: 1,
                quantity: 3
            );
            // 6. Sale executes - Ted buys one copy of Mario with $20 delivery
            //                    and uses 200 loyalty points for $20 off
            store.ExecuteSale(
                customerID: 1,
                productID: 2,
                quantity: 1,
                delivery: true,
                spendLoyalty: true
            );
            // 7. Display customer and product details
            store.CustomerDB.DisplayAll();
            store.ProductDB.DisplayAll();
        }
    }
}
