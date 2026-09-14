WhatsApp Image 2026-09-14 at 4.52.09 PM.jpeg

-- code --
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;

--explain 
After line 1, o1 stores the address of the Order object on the heap.
After line 2, o2 receives the same reference as o1, so both variables point to the same heap object.
After line 3, o2.IsPaid = true changes the same heap object, so both o1 and o2 see the updated value.
