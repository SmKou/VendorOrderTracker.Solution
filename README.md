# Vendor and Order Tracker

By: Stella Marie

Asp.Net MVC app for managing vendors and orders for Pierre's Bakery.

Refer to [Pierre's Bakery](https://github.com/SmKou/PierresBakery.Solution)

## Technologies Used

- C#
- .NET 6.0

## Description

Vendor and Order Tracker is an MVC application to help a bakery owner track the vendors that purchase their goods and the orders belonging to each vendor. For vendors, the bakery owner keeps track of their name, supplies a description and adds orders to the list on their account. Orders consist of a title, description, price and date at minimum.

The homepage consists of a splash page for the app's main function, from which the bakery owner can access the vendors page and view their orders. The vendors page provides a link for creating a new vendor and once filled out, the app reroutes to the vendors page. On each vendor's page is a link to create a new order.

### Under Consideration

- View order page
- Delete vendors or all vendors
- Delete all orders from vendor or individual orders
- Update vendor or order details
- Update paid status of order
- Add search capabilities
- Add data loading and storing

## Complete Setup

- Navigate to main page of repo
- Clone or Fork project

```bash
dotnet run --project VendorOrderTracker
```

Or
- cd into project main folder: VendorOrderTracker
- Run bash command without project redirection: --project ProjectName

If you are going to make changes and would like to see how those changes affect your app in realtime, use:
```bash
dotnet watch run --project VendorOrderTracker
```

Reminder: If you make changes to the Models, these changes require a restart of the server.

## Known Bugs

Please report any issues in using this app.

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2023 Sm Kou