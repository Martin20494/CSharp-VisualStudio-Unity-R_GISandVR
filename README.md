# CSharp-VisualStudio-Unity-R_GISandVR
C#, Visual Studio, Unity, and R - Geographic Information System and Virtual Reality - Global UCLEARN Users in the quaratine

Summary: The purpose of this project was to find the best way to visualise global location data from UC’s Learning Management System (LEARN) using Virtual Reality (VR). This would make it possible to see how the recent lockdown affected where users were logging in from. An increase in access to LEARN from different countries around the world had been observed, and it was desirable to get a clear understanding of what was happening using some form of visualisation. The outcome is a VR visualisation prototype, created using Unity, to be used with an Android phone and a Google Cardboard style device. It is designed so that given a file containing login data the user can view that data in VR by looking at a 3D globe. The user can manipulate the data by filtering by time and/or by grouped numbers of users using two sliders. Different viewpoints on the visualization can be achieved either by rotating the globe (clicking a Rotate button) or by transporting to different points around the globe (clicking on Satellites). The transportation allows the viewer to get a different perspective on how the lockdown affected the location of LEARN users.

Some pictures about the outcome of the project:

<img width="665" alt="Screen Shot 2020-10-29 at 9 30 36 PM" src="https://user-images.githubusercontent.com/55137629/97544950-2ca92600-1a2f-11eb-9806-313406289f58.png">

<img width="665" alt="Screen Shot 2020-10-29 at 9 34 27 PM" src="https://user-images.githubusercontent.com/55137629/97545092-5e21f180-1a2f-11eb-909d-6db5b61ca78e.png">

About the files: There are three folders as below. GISandVR is the main folder, the other folders are for substitute versions in case the main one did not work well.

- GISandVR: This folder is to easily see on github the work on data, C#, Visual Studio, and Unity.
  + The scripts are stored in this directory: GISandVR/Assets/Scripts
  + The scence can also be used to open the works (if after downloading the folder, the unity would not work), and it could be found in this directory: GISandVR/Assets/Scences/SampleScence.unity
  
- Unitypackage_GISandVR: This folder is to download the unity package, then to import to your local unity (in case that the other folder would not work well on your machine).

- Zipfile_GISandVR (full version): This folder contains the zip file, and this zip file includes:
  + Android package: Android_GISandVR.apk
  + An instruction: PLEASE READ ME FIRST.docx
  + A report: Report_GISandVR.docx
  + A unity package: GISandVR.unitypackage
