cnt_frames = int(input())

type_frame_inpt = input()
type_of_frame = {"90X130": 110, "100X150": 140, "130X180": 190, "200X300": 250}

delivery_method_inpt = input()
delivery_fee = 60

price = 0

if type_frame_inpt == "90X130":
    if 60 >= cnt_frames > 30:
        price = type_of_frame["90X130"] - type_of_frame["90X130"] * 0.05
    elif cnt_frames > 60:
        price = type_of_frame["90X130"] - type_of_frame["90X130"] * 0.08
elif type_frame_inpt == "100X150":
    if 60 >= cnt_frames > 30:
        price = type_of_frame["100X150"] - type_of_frame["100X150"] * 0.06
    elif cnt_frames > 60:
        price = type_of_frame["100X150"] - type_of_frame["100X150"] * 0.1
elif type_frame_inpt == "130X180":
    if 60 >= cnt_frames > 30:
        price = type_of_frame["130X180"] - type_of_frame["130X180"] * 0.07
    elif cnt_frames > 60:
        price = type_of_frame["130X180"] - type_of_frame["130X180"] * 0.12
elif type_frame_inpt == "200X300":
    if 60 >= cnt_frames > 30:
        price = type_of_frame["200X300"] - type_of_frame["200X300"] * 0.09
    elif cnt_frames > 60:
        price = type_of_frame["200X300"] - type_of_frame["200X300"] * 0.14

if delivery_method_inpt == "With delivery":
    price += delivery_fee

total_price = price * cnt_frames

if cnt_frames > 99:
    total_price -= total_price * 0.04

output = f"{total_price:.2f} BGN"
print(output)
