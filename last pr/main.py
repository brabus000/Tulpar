import tkinter as tk
from tkinter import filedialog
from PIL import Image, ImageTk
from deepface import DeepFace


def choose_file():
    file_path = filedialog.askopenfilename()
    if file_path:
        
        image = Image.open(file_path)
        image = image.resize((400, 400), Image.ANTIALIAS)
        photo = ImageTk.PhotoImage(image)
        image_label.config(image=photo)
        image_label.image = photo
      
        result = DeepFace.analyze(file_path, actions=['age', 'gender', 'race', 'emotion'])
        result_label.config(text=f"Age: {result[0]['age']}\nGender: {result[0]['gender']}\nRace: {result[0]['dominant_race']}\nEmotion: {result[0]['dominant_emotion']}")


window = tk.Tk()
window.title("Image Analyzer")
window.geometry("1260x600")
window.configure(bg="#282C34")


title_label = tk.Label(window, text="Image Analyzer", fg="#FFFFFF", bg="#282C34", font=("Arial", 20))
title_label.pack(pady=20)


image_label = tk.Label(window, bg="#282C34")
image_label.pack()


button = tk.Button(window, text="Choose Image", command=choose_file, bg="#4B4E5C", fg="#FFFFFF", font=("Arial", 14))
button.pack(pady=20)


result_label = tk.Label(window, fg="#FFFFFF", bg="#282C34", font=("Arial", 14))
result_label.pack(pady=50)


window.mainloop()



