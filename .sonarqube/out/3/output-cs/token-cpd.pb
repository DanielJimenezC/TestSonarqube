?
QD:\Programacion\NetCore\TestSonarqube\TestSonarqube\Controllers\TestController.cs
	namespace

 	
TestSonarqube


 
.

 
Controllers

 #
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
TestController 
:  !
ControllerBase" 0
{ 
[ 	
HttpGet	 
] 
public 
IActionResult 
GetTestValues *
(* +
)+ ,
{ 	
BoTest 
boTest 
= 
new 
BoTest  &
(& '
)' (
;( )
List 
< 
	TestModal 
> 
listado #
=$ %
boTest& ,
., -
GetTestModals- :
(: ;
); <
;< =
return 
Ok 
( 
listado 
) 
; 
} 	
} 
} ?

>D:\Programacion\NetCore\TestSonarqube\TestSonarqube\Program.cs
	namespace

 	
TestSonarqube


 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} ?
>D:\Programacion\NetCore\TestSonarqube\TestSonarqube\Startup.cs
	namespace 	
TestSonarqube
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
;% &
services 
. 
AddSwaggerGen "
(" #
c# $
=>% '
{   
c!! 
.!! 

SwaggerDoc!! 
(!! 
$str!! !
,!!! "
new!!# &
OpenApiInfo!!' 2
{!!3 4
Title!!5 :
=!!; <
$str!!= L
,!!L M
Version!!N U
=!!V W
$str!!X \
}!!] ^
)!!^ _
;!!_ `
}"" 
)"" 
;"" 
}## 	
public&& 
void&& 
	Configure&& 
(&& 
IApplicationBuilder&& 1
app&&2 5
,&&5 6
IWebHostEnvironment&&7 J
env&&K N
)&&N O
{'' 	
if(( 
((( 
env(( 
.(( 
IsDevelopment(( !
(((! "
)((" #
)((# $
{)) 
app** 
.** %
UseDeveloperExceptionPage** -
(**- .
)**. /
;**/ 0
app++ 
.++ 

UseSwagger++ 
(++ 
)++  
;++  !
app,, 
.,, 
UseSwaggerUI,,  
(,,  !
c,,! "
=>,,# %
c,,& '
.,,' (
SwaggerEndpoint,,( 7
(,,7 8
$str,,8 R
,,,R S
$str,,T f
),,f g
),,g h
;,,h i
}-- 
app// 
.// 
UseHttpsRedirection// #
(//# $
)//$ %
;//% &
app11 
.11 

UseRouting11 
(11 
)11 
;11 
app33 
.33 
UseAuthorization33  
(33  !
)33! "
;33" #
app55 
.55 
UseEndpoints55 
(55 
	endpoints55 &
=>55' )
{66 
	endpoints77 
.77 
MapControllers77 (
(77( )
)77) *
;77* +
}88 
)88 
;88 
}99 	
}:: 
};; 