# Xamarin Android Binding Library
Xamarin Binding Library for [lzyzsd/CircleProgress](https://github.com/lzyzsd/CircleProgress)

<img src="https://raw.githubusercontent.com/lzyzsd/CircleProgress/master/demos/circle_progress.gif" width="400" height="600" />

# Usage
 

Include the library via nuget
```
Install-Package Naxam.CirclerProgress.Droid
```
# Notice
please always use same width and height for progress views

# DonutProgress
<img src="https://raw.githubusercontent.com/lzyzsd/CircleProgress/master/demos/donutprogress_demo.png" width="100" height="100"/>
    
 
    <com.github.lzyzsd.circleprogress.DonutProgress
        android:layout_marginLeft="50dp"
        android:id="@+id/donut_progress"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        custom:donut_progress="30"/>
   
    attrs for DonutProgress
  
    <declare-styleable name="DonutProgress">
        <attr name="donut_progress" format="integer"/>
        <attr name="donut_max" format="integer"/>
        <attr name="donut_unfinished_color" format="color"/>
        <attr name="donut_finished_color" format="color"/>
        <attr name="donut_finished_stroke_width" format="dimension"/>
        <attr name="donut_unfinished_stroke_width" format="dimension"/>
        <attr name="donut_text_size" format="dimension"/>
        <attr name="donut_text_color" format="color"/>
        <attr name="donut_text" format="string"/>
        <attr name="donut_prefix_text" format="string"/>
        <attr name="donut_suffix_text" format="string"/>
        <attr name="donut_background_color" format="color"/>
    </declare-styleable>
 
# CircleProgress
<img src="https://raw.githubusercontent.com/lzyzsd/CircleProgress/master/demos/circleprogress_demo.png" width="100" height="100"/>
 

    <com.github.lzyzsd.circleprogress.CircleProgress
        android:id="@+id/circle_progress"
        android:layout_marginLeft="50dp"
        android:layout_width="100dp"
        android:layout_height="100dp"
        custom:circle_progress="20"/>
 
    attrs for CircleProgress
    
    <declare-styleable name="CircleProgress">
        <attr name="circle_progress" format="integer"/>
        <attr name="circle_max" format="integer"/>
        <attr name="circle_unfinished_color" format="color"/>
        <attr name="circle_finished_color" format="color"/>
        <attr name="circle_text_size" format="dimension"/>
        <attr name="circle_text_color" format="color"/>
        <attr name="circle_prefix_text" format="string"/>
        <attr name="circle_suffix_text" format="string"/>
    </declare-styleable>
   
# ArcProgress
<img src="https://raw.githubusercontent.com/lzyzsd/CircleProgress/master/demos/arcprogress_demo.png" width="100" height="100"/>


    <com.github.lzyzsd.circleprogress.ArcProgress
        android:id="@+id/arc_progress"
        android:background="#214193"
        android:layout_marginLeft="50dp"
        android:layout_width="100dp"
        android:layout_height="100dp"
        custom:arc_progress="55"
        custom:arc_bottom_text="MEMORY"/>
 
    ArcProgress
   
    <com.github.lzyzsd.circleprogress.ArcProgress
        android:id="@+id/arc_progress"
        android:background="#214193"
        android:layout_marginLeft="50dp"
        android:layout_width="100dp"
        android:layout_height="100dp"
        custom:arc_progress="55"
        custom:arc_bottom_text="MEMORY"/>
 

# License
This binding is licensed under the MIT license, but the native Java library is license under the Apache License by Yalantis.

    Copyright 2017, Yalantis

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.