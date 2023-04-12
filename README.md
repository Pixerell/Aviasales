# Aviasales
A desktop app for buying aviatickets written in C# with SQL database.

To check the app out:

  1 - Open the main aviasales solution file in visual studio
  
  2 - If there are problems with database, load SQL database file in "Baza" folder
  
  3 - To check the API controllers open the AviasalesAPI.sln file in visual studio
  
  4 - If you have issues with Hotels API, check the API configs on https://rapidapi.com/tipsters/api/booking-com/ 
  (they might have changed them)
  
  5 - Close it for your safety
  

# Here are the examples of how the app is supposed to look

  I - Login screen. Function "Remember me" works with VS: Properties.Settings.Default. Of course you can register a 
  new user by clicking "Create User" and filling out the forms.
  
  ![image](https://user-images.githubusercontent.com/90747184/231537334-653fa2fc-ba0d-4905-ae95-d239a70453b3.png)
  
  II - Main page (With flights selected), you can use filters to search available flights, cancel them 
  (if you logged in as a manager/admin) and buy tickets here.
  
  ![image](https://user-images.githubusercontent.com/90747184/231537661-0a818a0e-47ed-495b-8a93-164f2c28dd7d.png)
  
  III - You can buy tickets not only for yourself but for other users aswell, granted if you know their information. 
  ![image](https://user-images.githubusercontent.com/90747184/231537889-dd8b4182-28c5-4bf8-b3e1-757177bdd32e.png)
  
  IV - Hotels API Page. Works with Booking.com API, using RestSharp client as a base. This page shows the available hotels
  for the city that you selected, using a query to booking.com.
  ![image](https://user-images.githubusercontent.com/90747184/231538041-f0ca6d8b-9935-4495-bdc0-60cb3bb1f8c5.png)
  
  V - Notifications page. If you click on a hotel in Hotels API Page, you will be able to set a notification, which triggers
  when the price on that hotel changes in your desired direction. To check if the price has changed this app sends API requests
  to booking.com, and compares the prices of the hotel itself and your notification. 
  ![image](https://user-images.githubusercontent.com/90747184/231538408-9419c37d-4edd-4dc7-a55d-65a3ccec7ab2.png)
  
  VI - Profile page. This contains information about your current profile, purchased tickets and the option to log out
  (which disables "Remember me" function). You also can redact your profile here. If you logged in as a manager or admin,
  there will be an additional option to check all users, just like you checked all flights.
  ![image](https://user-images.githubusercontent.com/90747184/231538813-f921ced3-0627-4f27-88fe-2668548fe711.png)
  
# Additional tools
  
  1 - SQL Database, that's integrated in this project (Model1.edmx)
  
  ![image](https://user-images.githubusercontent.com/90747184/231540389-042d10ec-fe4d-4af9-91e0-9a007b15c113.png)
  
  2 - Custom WebAPI with standard conrollers for easier access to database (and honestly cuz I wanted that)

  ![image](https://user-images.githubusercontent.com/90747184/231541708-44026bd6-2dcd-477a-a865-337f4a2a8c49.png)


# This project holds up surprisingly well ;)



