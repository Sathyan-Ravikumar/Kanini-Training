use northwind;
select * from customers
insert categories values('confections','Ddeserts,candies and sweet breads');
insert categories values('Meat/poultry','Prepared meats');
insert categories values('seafood','Seaweed and fish');

select CategoryName, "Description" from categories order by CategoryName;

select ContactName, CompanyName, ContactTitle,Phone from Customers order by phone;

select FirstName,LastName,HireDate from Employees order by HireDate desc;

select orderid,orderdate,shippedDate,Customerid,Freight from orders order by Freight desc;

select CompanyName, Fax, Phone, HomePage,Country from Suppliers order by country desc ,companyName asc;

select companyname,contactname from Customers
where contactname like 'bue%'

select productname,unitprice,QuantityPerUnit from Products where UnitsInStock<1;

select orderdate, shippeddate, customerid,  freight from orders where orderdate='1997-05-19';

select  firstname, lastname,country from employees where  country not in('USA');

select employeeid, orderid, customerid, requireddate,  shippeddate from orders where RequiredDate<ShippedDate;

select city, companyname,  contactname from customers where city like 'A%' or city like 'B%';

select * from orders where freight>500;

select productname, unitsinstock, unitsonorder,reorderlevel from products where UnitsInStock<=ReorderLevel;

select companyname, contactname,fax  from customers where fax is NOT NULL;

select firstname,lastname from Employees where ReportsTo is NULL;

select companyname, contactname,fax from customers where fax is not null order by CompanyName;

select city, companyname,contactname from Customers where city like 'A%' or city like'B%' order by ContactName desc;

select firstname , lastname,birthdate from Employees where year(BirthDate) between 1950 and 1959;

select productname,supplierid from products where SupplierID in(select supplierid from Suppliers where companyname in ('Exotic Liquids', 'Grandma
Kelly''s Homestead','Tokyo Traders'));

select shippostalcode, orderid, orderdate from orders where ShipPostalCode like '02389%';

select contactname,ContactTitle,companyname from customers where ContactTitle not like '%sales%';

select firstname,lastname,city from employees where city not like '%seattle%';

select companyname, contacttitle, city , country from customers where Country='mexico' or country='spain' and city <> 'madrid';