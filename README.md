This simple program  allows a user to build a pizza, submit the pizza order, and display the total cost of the order including tax and tip. 
1.	The pizza builder form needs controls to allow the user to enter the customer’s information (name, phone, address, etc…), build a pizza, and submit the order.
a) Form controls for the user to enter their name, phone number, and address information including the city, state, and zipcode.
b)	 A drop-down box or radio button group to allow the customer to select delivery or pickup.
c)	 A drop-down box or radio button group to allow the customer to select the size of the pizza (small, medium, large, extra-large).
d)	 Form controls that allows the customer to make selections and customize their pizza.
i.	Selection for regular crust, stuffed crust, deep dish, thin crust, or cheesy garlic butter crust.
ii.	Selection for sauce (tomato, white, pesto, etc) 
iii.	Checkboxes for toppings like pepperoni, sausage, bacon, ham, onions, peppers, etc… The checkboxes will allow the customer to choose as many as they like.
iv.	Checkboxes premium additions like extra cheese, extra meat, etc… The checkboxes will allow the customer to choose as many as they like.
v.	Option to tip the staff. The tip will get added to the total cost of the order during server-side processing. Use a textbox to allow the customer to enter a numerical value for the tip. A blank textbox would signify the customer is not including a tip.
vi.	Provide at least 10 choices for each of the above categories.
vii. Assign costs for all pizza size selections, toppings, premium additions, crust types, and sauces. The cost of the pizza will be based on the user’s selections and the costs for each selection. 
viii.	Using a mixture of drop-down boxes, radio button groups, and checkboxes to allow the user to build their customized pizza order.
b)	Display an image for the selected crust type. This image should change each time the user chooses a type of crust. 
c)	 A button to allow the user to submit the order. This button should redirect the user to the order confirmation form that will display the receipt of the transaction.

2.	The program has 3 classes: Pizza, Customer, and Order. The Pizza class represents a single pizza that was built by the customer based on the selections made from the Form (GUI). This class contain fields that represent the attributes of the pizza, constructors, and properties to get/set the fields in the class. The Customer class represents the person that made the order. This Customer class should contain fields that represent the important attributes of a customer, constructors, and properties to get/set the fields of the class. The Order class will store information related to the order like the date and time the order was place, the Customer who placed the order, and a Pizza the customer built. The Order class will be responsible for calculating the cost of the order.  These classes should be written in a separate class file from the Form’s class file. The Order class  have methods to store/retrieve a customer, store/retrieve the pizza, calculate the cost of the order, and any other necessary operations.
3.	The order confirmation form will be used to display the order that was placed successfully. This form  display the customer’s information, the pizza the user built, and total cost of the order. 
a.	This form serves as a receipt of the transaction.
b.	The data displayed in this form come from the appropriate objects (Pizza, Customer, Order).



