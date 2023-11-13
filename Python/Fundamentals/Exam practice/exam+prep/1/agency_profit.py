air_company_name = input()
adult_ticket_cnt = int(input())
kids_ticket_cnt = int(input())

adult_ticket_price = float(input())
kids_ticket_price = adult_ticket_price - adult_ticket_price * 0.70

service_fee = float(input())

adult_ticket_price += service_fee
kids_ticket_price += service_fee

total_tickets = (adult_ticket_cnt * adult_ticket_price) + (kids_ticket_cnt * kids_ticket_price)

profit = total_tickets * 0.2

output = f"The profit of your agency from {air_company_name} tickets is {profit:.2f} lv."
print(output)
