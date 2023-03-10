# ----------------------------- Import Libraries ------------------------------ 

import geopandas as gpd                    # For PreProcessing & Visualization
import tkinter as tk                       # For GUI
from tkinter import filedialog as fd       # For Work with Files
import matplotlib.pyplot as plot           # For Plot

# ------------------------------- Define CLASS --------------------------------

class Read_GeoJSON:
    
    def __init__(self, file_path):
        
        self.file_path = file_path
        self.GeoJSONDataFrame = gpd.read_file(self.file_path)     # Read GeoJSON File
        
        self.GeoJSONDataFrame.plot()                              # Plot
        plot.title('GeoJSON File')
        plot.xlabel('Easting')
        plot.ylabel('Northing')
        
# -------------------------------- Use CLASS ----------------------------------

Page = tk.Tk()
file_path = fd.askopenfilename(title='Select GeoJSON File', filetypes=(('GeoJSON', '*.geojson'), ('All Files', '*.*')))
Page.destroy()

# ----------------------------- Error Management ------------------------------

if (file_path[-8:] == ".geojson"):
    Read_GeoJSON(file_path)
else:
    print('Something went wrong! Please choose a file in correct format.')
    
# -----------------------------------------------------------------------------