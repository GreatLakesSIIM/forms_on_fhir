import sys
import json
from datetime import datetime
from datetime import timedelta
import jsonschema
import tkinter as tk
from tkinter import ttk
import requests
from bs4 import BeautifulSoup


def newSelection(event):
    print("New element selected")


with open('fhir.schema.json', encoding='cp850') as f:
    schema = json.load(f)

patientSchema = schema['definitions']['Patient']

app = tk.Tk()

labelTop = tk.Label(
    app, text="Select an Administrative resourceType to create")
labelTop.grid(column=0, row=0)

administrativeResourcesCombo = ttk.Combobox(app, values=[
    "Patient", "Practitioner", "CareTeam", "Device", "Organization", "Location", "Healthcare Service"])

administrativeResourcesCombo.grid(column=0, row=1)
administrativeResourcesCombo.current(0)
administrativeResourcesCombo.bind("<<ComboboxSelected>>", newSelection)

app.mainloop()
