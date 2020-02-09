Modeling MATLAB .NET Assembly (.NET Component)

1. Prerequisites for Deployment 

Verify that version 9.3 (R2017b) of the MATLAB Runtime is installed.   

If the MATLAB Runtime is not installed, you can run the MATLAB Runtime installer.
To find its location, enter
  
    >>mcrinstaller
      
at the MATLAB prompt.

Alternatively, download and install the Windows version of the MATLAB Runtime for R2017b 
from the following link on the MathWorks website:

    http://www.mathworks.com/products/compiler/mcr/index.html
   
For more information about the MATLAB Runtime and the MATLAB Runtime installer, see 
Package and Distribute in the MATLAB Compiler SDK documentation  
in the MathWorks Documentation Center.    

NOTE: You will need administrator rights to run the MATLAB Runtime installer. 


2. Files to Deploy and Package

-Modeling.dll
   -contains the generated component using MWArray API. 
-ModelingNative.dll
   -contains the generated component using native API.
-This readme file
    Note: if end users are unable to download the MATLAB Runtime using the
    instructions in the previous section, include it when building your 
    component by clicking the "Runtime downloaded from web" link in the
    Deployment Tool.


Auto-generated Documentation Templates:

MWArray.xml - This file contains the code comments for the MWArray data conversion 
              classes and their methods. This file can be found in either the component 
              distrib directory or in
              <mcr_root>*\toolbox\dotnetbuilder\bin\win64\v2.0

Modeling_overview.html - HTML overview documentation file for the generated component. It 
                         contains the requirements for accessing the component and for 
                         generating arguments using the MWArray class hierarchy.

Modeling.xml - This file contains the code comments for the Modeling component classes 
                         and methods. Using a third party documentation tool, this file 
                         can be combined with either or both of the previous files to 
                         generate online documentation for the Modeling component.


3. Resources

To learn more about:               See:
===================================================================
MWArray classes                    <matlab_root>*\help\toolbox\
                                   dotnetbuilder\MWArrayAPI\
                                   MWArrayAPI.chm  
Examples of .NET Web Applications  Web Deployment in the MATLAB   
                                   .NET Assembly documentation in the  
                                   MathWorks Documentation Center


4. Definitions

For information on deployment terminology, go to
http://www.mathworks.com/help and select MATLAB Compiler >
Getting Started > About Application Deployment >
Deployment Product Terms in the MathWorks Documentation
Center.

* NOTE: <mcr_root> is the directory where the MATLAB Runtime is installed on the target 
        machine.
        <matlab_root> is the directory where MATLAB is installed on the target machine.

