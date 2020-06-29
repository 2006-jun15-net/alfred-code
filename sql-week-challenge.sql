--adding to Products
Insert into Products
values(1, 'Soy Milk', 3.50),
(2, 'Milk', 1.00), (3, 'Orange Juice', 2.00);


--adding customers
Insert into Customers
values(20, 'Alfred', 'Rwagaju', '1234'),
(30, 'Luis', 'Gomez', '2314'), (40, 'Ramos','Sergio', '3412');


--adding to orders
Insert into Orders
values(100, 1, 30), (200, 2, 40),(300, 3, 20);


--adding product iPhone price at $200
Insert into Products
values(4, 'iPhone', 200.00);

--adding customer Tina Smith
Insert into Customers
values(50, 'Tina', 'Smith', '4321');

--inserting Tina's order in Orders table
insert into Orders
values(400, 4, 50)

--selecting all orders by Tina
select *
from Orders right join Customers on Orders.CustomerID = Customers.ID
where FirstName = 'Tina' and LastName = 'Smith'

--report all revenues
select SUM(*)
from Products
where Name = 'iPhone';

--increase the price of iPhone
Update  Products
set Price =  450.00
where Name = 'iPhone;













