<div><br>
</div>
<div>
<table border="1" bordercolor="#888" cellspacing="0" style="border-collapse:collapse;border-color:rgb(136,136,136);border-width:1px">
<tbody>
<tr>
<td style="width:172px"><span style="font-size:13.3333px;line-height:21.3333px">Ctrl - Shift - F</span>&nbsp;</td>
<td style="width:496px">&nbsp;Format Code, XML,</td>
</tr>
<tr>
<td style="width:172px;height:19px">F9</td>
<td style="width:496px;height:19px">&nbsp;Run</td>
</tr>
<tr>
<td style="width:172px;height:19px">&nbsp;Ctrl - Click or F3</td>
<td style="width:496px;height:19px">&nbsp;Goto Definition</td>
</tr>
<tr>
<td style="width:172px;height:19px">&nbsp;Ctrl - 0</td>
<td style="width:496px;height:19px">&nbsp;Code Outline</td>
</tr>
<tr>
<td style="width:172px;height:19px">&nbsp;Alt - Shift - ArrowUp</td>
<td style="width:496px;height:19px">&nbsp;Select block</td>
</tr>
<tr>
<td style="width:172px;height:19px">&nbsp;Ctrl - /</td>
<td style="width:496px;height:19px">&nbsp;Toggle Comments on/off</td>
</tr>
<tr>
<td>&nbsp;Alt - Enter</td>
<td>&nbsp;Properties</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</tbody>
</table>
<br>
</div>
<div><br>
</div>
<div><br>
</div>
<div><br>
</div>
Window - Preferences - General - Keys - (Include unbound commands: CHECKED)<br>
&nbsp;&nbsp;&nbsp; ^P&nbsp;&nbsp; Prefererences...<br>
&nbsp;&nbsp;&nbsp; ^Tab Next Editor<br>
&nbsp;&nbsp;&nbsp; F8&nbsp; -&gt; Build Project (And uncheck "Menu Project - Build Automatically")<br>
&nbsp;&nbsp;&nbsp; F9&nbsp; -&gt; Run Java Application<br>
&nbsp;&nbsp;&nbsp; F10 -&gt; Run Last External Tool<br>
&nbsp;&nbsp;&nbsp; <br>
&nbsp;&nbsp;&nbsp; Already default:&nbsp; F3&nbsp;&nbsp; Open Declaration<br>
<pre>Preferences - General - Editors: Restore editor state on startup (Uncheck) 
Preferences - General - Editors - Text Editors - Spelling: Enable spell checking (Uncheck)   
Preferences - General - Editors - Text Editors:  Insert spaces for tabs: CHECKED, Show print margin: 90 
Preferences - General - Web Browser:  Use external Web browswer (Select)
#Preferences - Java - Formatter:  Line wrap (off)
   
</pre>
<p>--- </p>
<ul>
<li>Abbreviations*: </li></ul>
<pre>Java -&gt; Editor -&gt; Templates
  Edit sysout,  change name to sop, Click "YES" to create new template sop instead of replacing sysout.   
</pre>
<p>--- </p>
<pre>Preferences - Java - Build Path - Classpath Variables - New: COMMON_LIB_DIR =  C:\java\common_lib
so the Eclipse file ".classpath"
  &lt;classpathentry kind="var" path="COMMON_LIB_DIR/oracle_jdbc_classes12.jar"/&gt;   
</pre>
<p>--- </p>
<pre> Preferences -- Run/Debug -- Lauching -- Save required dirty editors before launching = ALWAYS
</pre>
<hr>
<pre>Open External Tools Dialog:
      Ant Build
         Name: Save to db_pubs - bellagio-dev
            buildfile: C:\Tools\ant_scripts\ftp_save_file_bellagio-dev_db_pubs.ant.xml
            BaseDir: c:\temp1
            Arguments: -DFile="${resource_loc}"
      
         Name: ant -f build.xml
         buildfile: ${project_loc}\build.xml
         BaseDir: ${project_loc}
         Arguments: 
</pre>
<pre>      Program 
    
    External Tools Configurations -- new Program
       Name = "Run Lua"
       location = c:\lua\bin\lua.exe
       Arguments = ${resource_loc}
</pre>
<p><br>
</p>
<a name="Misc"></a>
<h2><span>[<a href="http://wiki.lihaco.com/index.php?title=Eclipse&amp;action=edit&amp;section=2" title="Edit section: Misc"><font color="#0066cc">edit</font></a>]</span> <span>Misc </span></h2>
<p>Task Tags: "bmx", @todo, FIXME, TODO, XXX. </p>
<a name=".3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D"></a>
<h6><span>[<a href="http://wiki.lihaco.com/index.php?title=Eclipse&amp;action=edit&amp;section=3" title="Edit section: ====================================================================="><font color="#0066cc">edit</font></a>]</span> <span>=====================================================================</span></h6>
<p>E:\XApps\eclipse\configuration\.settings\org.eclipse.ui.ide.prefs </p>
<pre> RECENT_WORKSPACES=C\:\\Temp1\\eclipse_ws_cdis_Passport_E,C\:\\temp1\\eclipse_ws1
</pre>
<a name=".3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D"></a>
<h6><span>[<a href="http://wiki.lihaco.com/index.php?title=Eclipse&amp;action=edit&amp;section=4" title="Edit section: ======================================================================"><font color="#0066cc">edit</font></a>]</span> <span>======================================================================</span></h6>
<ul>
<li>General*: </li></ul>
<pre> Open existing project:    File -&gt; Import -&gt; General -&gt; Existing Projects into Workspace
</pre>
<pre>  ${resource_loc}: Absolute file system path of a resource [c:\path\to\file1.xml]
  ${project_loc}: Absolute file system path [c:\projects\MyProject2]
  
</pre>
<p>c:\eclipse\workspace and you have two projects, MyProject1 and MyProject2. The first project, MyProject1, is located inside the workspace directory, the second project, MyProject2, is located outside the workspace directory at c:\projects\MyProject2. Lets look at how the variable examples below will be expanded when an external tool is run, if the resource /MyProject2/MyFolder/MyFile.txt is selected. </p>
<pre>  ${build_type} none 
  ${workspace_loc} c:\eclipse\workspace 
  ${workspace_loc:/MyProject1/MyFile.txt} c:\eclipse\workspace\MyProject\MyFile.txt 
  ${workspace_loc:/MyProject2/MyFile.txt} c:\projects\MyProject2\MyFile.txt 
  ${project_loc} c:\projects\MyProject2 
  ${project_loc:/MyProject1/MyFile.txt} c:\eclipse\workspace\MyProject 
  ${container_loc} c:\projects\MyProject2\MyFolder 
  ${resource_loc} c:\projects\MyProject2\MyFile.txt 
  ${project_path} /MyProject2 
  ${container_path} /MyProject2/MyFolder 
  ${resource_path} /MyProject2/MyFolder/MyFile.txt 
  ${project_name} MyProject2 
  ${container_name} MyFolder 
  ${resource_name} MyFile.txt 
</pre>
<p><br>
</p>
<a name=".3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D.3D_2"></a>
<h6><span>[<a href="http://wiki.lihaco.com/index.php?title=Eclipse&amp;action=edit&amp;section=5" title="Edit section: ======================================================================"><font color="#0066cc">edit</font></a>]</span> <span>======================================================================</span></h6>
<ul>
<li>Project Files*: </li></ul>
<pre> .project
</pre>
<hr>

<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt; &lt;projectDescription&gt; </p>
<pre>  &lt;name&gt;cdis_tomcat&lt;/name&gt;
  &lt;comment&gt;&lt;/comment&gt;
  &lt;projects&gt;
  &lt;/projects&gt;
  &lt;buildSpec&gt;
     &lt;buildCommand&gt;
        &lt;name&gt;org.eclipse.jdt.core.javabuilder&lt;/name&gt;
        &lt;arguments&gt;
        &lt;/arguments&gt;
     &lt;/buildCommand&gt;
  &lt;/buildSpec&gt;
  &lt;natures&gt;
     &lt;nature&gt;org.eclipse.jdt.core.javanature&lt;/nature&gt;
  &lt;/natures&gt;
  &lt;linkedResources&gt;
     &lt;link&gt;
        &lt;name&gt;eclipse_classes4Run&lt;/name&gt;
        &lt;type&gt;2&lt;/type&gt;
        &lt;location&gt;C:/Temp1/eclipse_classes/cdis-bellagio-dev&lt;/location&gt;
     &lt;/link&gt;
     &lt;link&gt;
        &lt;name&gt;ROOT/WEB-INF/classes_eclipse/eclipse_classes&lt;/name&gt;
        &lt;type&gt;2&lt;/type&gt;
        &lt;location&gt;C:/Temp1/eclipse_classes/cdis-bellagio-dev&lt;/location&gt;
     &lt;/link&gt;
  &lt;/linkedResources&gt;
</pre>
<p>&lt;/projectDescription&gt; </p>
<hr>

<p>Preferences - Java - Build Path - Classpath Variables - New: COMMON_LIB_DIR = C:\java\common_lib </p>
<pre> .classpath
</pre>
<hr>
<pre>   &lt;?xml version="1.0" encoding="UTF-8"?&gt;
   &lt;classpath&gt;
</pre>
<p>&lt;classpathentry kind="src" path="src"/&gt; &lt;classpathentry kind="con" path="org.eclipse.jdt.launching.JRE_CONTAINER"/&gt; &lt;classpathentry kind="lib" path="C:/yms1701/home/db_pubs/common_lib/oracle_jdbc_classes12.zip"/&gt; &lt;classpathentry kind="lib" path="C:/yms1701/home/db_pubs/cdis_tomcat5.5/common/lib/servlet-api.jar"/&gt; </p>
<pre>  &lt;classpathentry kind="var" path="COMMON_LIB_DIR/oracle_jdbc_classes12.jar"/&gt;   
</pre>
<p>&lt;classpathentry kind="output" path="ROOT/WEB-INF/classes"/&gt; </p>
<pre>  &lt;classpathentry kind="output" path="eclipse_classes4Run"/&gt;
    &lt;/classpath&gt;
</pre>
<hr>
