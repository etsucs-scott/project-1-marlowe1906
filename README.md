Adventure Game – Player Instructions
Objective:
Explore the room, defeat monsters, collect potions and weapons, and reach the exit.

Controls:
W - Move Up
S - Move Down
A - Move Left
D - Move Right
E - Inventory
Q - Player stats

Tile Types:
.	Empty floor — move freely
#	Wall — cannot pass
P	Player start position
E	Exit — finish the level (only if all monsters defeated)
M	Monster — triggers a battle
I	Item — Can be a potion that restores 10 health / Can be a sword with different damage amounts 

Battles sequence using reflexes:
Wait until prompted to attack then press any key to attack the monster
If you dont attack fast enough, the monster will attack you 
Defeat the monster before it can attack you!

Player loses if health drops to 0 or lower.
Player wins if monster’s health reaches 0 or less.

Winning:
Defeat all monsters and move to the exit (E) to complete the level.

Losing:
If your health reaches 0 in battle, the game ends.

Run instruction:
 1 - .NET SDK installed (recommended .NET 6 or newer) or A C# IDE such as:
 - Visual Studio OR
 - Visual Studio Code with C# extension OR
 - Rider

Using cmd prompt:
 2 - cd YourGameFolder
 3 - dotnet build
 4 - dotnet run --project src/AdventureGame.Console

UML:
<mxfile host="app.diagrams.net" agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/145.0.0.0 Safari/537.36" version="29.5.3">
<diagram name="Page-1" id="1_HHXs_IazP9HPB8a2zH">
<mxGraphModel dx="2292" dy="1194" grid="0" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="0" pageScale="1" pageWidth="850" pageHeight="1100" math="0" shadow="0">
<root>
<mxCell id="0"/>
<mxCell id="1" parent="0"/>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-3" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0;entryY=0.25;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-54">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-1" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Program" vertex="1">
<mxGeometry height="60" width="160" x="-222" y="784" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-2" parent="nUxuXlOaQanOZV29W_tj-1" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ roomData: str" vertex="1">
<mxGeometry height="26" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-3" parent="nUxuXlOaQanOZV29W_tj-1" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="52" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-8" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Movement" vertex="1">
<mxGeometry height="134" width="160" x="100" y="760" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-9" parent="nUxuXlOaQanOZV29W_tj-8" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ currentLocation: int<div>+ newLocation: int</div><div>+ splitMap: char[]</div><div>+ newData: str</div>" vertex="1">
<mxGeometry height="74" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-10" parent="nUxuXlOaQanOZV29W_tj-8" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="100" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-11" parent="nUxuXlOaQanOZV29W_tj-8" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ move(str, int, int, obj)" vertex="1">
<mxGeometry height="26" width="160" y="108" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-14" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-62">
<mxGeometry relative="1" as="geometry">
<Array as="points">
<mxPoint x="433" y="553"/>
<mxPoint x="602" y="553"/>
<mxPoint x="602" y="451"/>
</Array>
</mxGeometry>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-15" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.75;exitY=0;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-24">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-16" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.25;exitDx=0;exitDy=0;entryX=0;entryY=0.25;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-17">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-13" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Relocate" vertex="1">
<mxGeometry height="120" width="190" x="338" y="664" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-14" parent="nUxuXlOaQanOZV29W_tj-13" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ choice: str<div>+ result: str</div>" vertex="1">
<mxGeometry height="44" width="190" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-15" parent="nUxuXlOaQanOZV29W_tj-13" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="190" y="70" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-16" parent="nUxuXlOaQanOZV29W_tj-13" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ relocate(str, int, int, char[], obj)" vertex="1">
<mxGeometry height="42" width="190" y="78" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-17" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Potion" vertex="1">
<mxGeometry height="60" width="160" x="667" y="638" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-19" parent="nUxuXlOaQanOZV29W_tj-17" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-20" parent="nUxuXlOaQanOZV29W_tj-17" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ retrieve(obj)" vertex="1">
<mxGeometry height="26" width="160" y="34" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-21" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Weapon" vertex="1">
<mxGeometry height="100" width="160" x="667" y="509" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-23" parent="nUxuXlOaQanOZV29W_tj-21" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-24" parent="nUxuXlOaQanOZV29W_tj-21" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ ironSword(obj)<div>+ goldSword(obj)</div><div>+ diamondSword(obj)</div>" vertex="1">
<mxGeometry height="66" width="160" y="34" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-25" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="MonsterCheck" vertex="1">
<mxGeometry height="86" width="200" x="446" y="243" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-26" parent="nUxuXlOaQanOZV29W_tj-25" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ monsters: int" vertex="1">
<mxGeometry height="26" width="200" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-27" parent="nUxuXlOaQanOZV29W_tj-25" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="200" y="52" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-28" parent="nUxuXlOaQanOZV29W_tj-25" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ checkForMonsters(string): int" vertex="1">
<mxGeometry height="26" width="200" y="60" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-29" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Attack" vertex="1">
<mxGeometry height="150" width="160" x="257" y="238" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-30" parent="nUxuXlOaQanOZV29W_tj-29" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ battle: bool<div>+ time: int</div><div>+ attacked: bool</div>" vertex="1">
<mxGeometry height="54" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-31" parent="nUxuXlOaQanOZV29W_tj-29" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="80" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-32" parent="nUxuXlOaQanOZV29W_tj-29" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ stats(obj, obj): str<div>+ easySequence(obj): str</div><div>+ hardSequence(obj): str</div>" vertex="1">
<mxGeometry height="62" width="160" y="88" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-33" parent="1" style="verticalAlign=top;align=left;overflow=fill;html=1;whiteSpace=wrap;" value="<p style="margin:0px;margin-top:4px;text-align:center;"><i>&lt;&lt;Interface&gt;&gt;</i><br><b>ICharecter</b></p><hr size="1" style="border-style:solid;"><p style="margin:0px;margin-left:4px;">+ Name: str</p><p style="margin:0px;margin-left:4px;">+ Health: int<br>+ AttackPower: int</p><hr size="1" style="border-style:solid;"><p style="margin:0px;margin-left:4px;">+ Attack(Interface)<br>+ takeDamage(int)</p>" vertex="1">
<mxGeometry height="140" width="190" x="84" y="1168" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-34" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="LocatePlayer" vertex="1">
<mxGeometry height="60" width="160" x="667" y="335" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-36" parent="nUxuXlOaQanOZV29W_tj-34" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-37" parent="nUxuXlOaQanOZV29W_tj-34" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ getLocation(str): int" vertex="1">
<mxGeometry height="26" width="160" y="34" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-42" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Monster:ICharecter" vertex="1">
<mxGeometry height="130" width="154" x="-38" y="243" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-43" parent="nUxuXlOaQanOZV29W_tj-42" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Name: str<div>+ Health: int</div><div>+ AttackPower: int</div>" vertex="1">
<mxGeometry height="54" width="154" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-44" parent="nUxuXlOaQanOZV29W_tj-42" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="154" y="80" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-45" parent="nUxuXlOaQanOZV29W_tj-42" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Attack(Interface)<div>+ takeDamage(int)</div>" vertex="1">
<mxGeometry height="42" width="154" y="88" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-46" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="Player:ICharecter" vertex="1">
<mxGeometry height="140" width="160" x="100" y="956" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-47" parent="nUxuXlOaQanOZV29W_tj-46" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Name: str<div>+ Health: int</div><div>+ AttackPower: int</div><div>+ Inventory: list</div>" vertex="1">
<mxGeometry height="64" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-48" parent="nUxuXlOaQanOZV29W_tj-46" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="90" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-49" parent="nUxuXlOaQanOZV29W_tj-46" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Attack(Interface)<div>+ takeDamage(int)</div>" vertex="1">
<mxGeometry height="42" width="160" y="98" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-50" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="RecreateRoom" vertex="1">
<mxGeometry height="104" width="160" x="353" y="876" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-51" parent="nUxuXlOaQanOZV29W_tj-50" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ splitData: char[]<div>+ placeholder: int</div>" vertex="1">
<mxGeometry height="44" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-52" parent="nUxuXlOaQanOZV29W_tj-50" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="70" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-53" parent="nUxuXlOaQanOZV29W_tj-50" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Generate(str, int, int): str" vertex="1">
<mxGeometry height="26" width="160" y="78" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-54" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="RoomGeneration" vertex="1">
<mxGeometry height="86" width="160" x="100" y="620" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-55" parent="nUxuXlOaQanOZV29W_tj-54" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ mapData: str" vertex="1">
<mxGeometry height="26" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-56" parent="nUxuXlOaQanOZV29W_tj-54" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="52" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-57" parent="nUxuXlOaQanOZV29W_tj-54" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Generate(int, int): str" vertex="1">
<mxGeometry height="26" width="160" y="60" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-58" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="RoomPlacement" vertex="1">
<mxGeometry height="86" width="160" x="103" y="471" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-59" parent="nUxuXlOaQanOZV29W_tj-58" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ type: int" vertex="1">
<mxGeometry height="26" width="160" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-60" parent="nUxuXlOaQanOZV29W_tj-58" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="160" y="52" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-61" parent="nUxuXlOaQanOZV29W_tj-58" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ Type(): str" vertex="1">
<mxGeometry height="26" width="160" y="60" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-62" parent="1" style="swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;whiteSpace=wrap;html=1;" value="WeaponChance" vertex="1">
<mxGeometry height="60" width="210" x="669" y="421" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-64" parent="nUxuXlOaQanOZV29W_tj-62" style="line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;strokeColor=inherit;" value="" vertex="1">
<mxGeometry height="8" width="210" y="26" as="geometry"/>
</mxCell>
<mxCell id="nUxuXlOaQanOZV29W_tj-65" parent="nUxuXlOaQanOZV29W_tj-62" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;whiteSpace=wrap;html=1;" value="+ choose(str, int, int, char[], obj): type" vertex="1">
<mxGeometry height="26" width="210" y="34" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-2" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-9">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-4" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=1;exitDx=0;exitDy=0;entryX=-0.002;entryY=0.045;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-47">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-5" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-33" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0.493;entryY=0.996;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-49">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-7" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=0.508;entryY=1.021;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-16">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-8" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=0.5;entryY=0;entryDx=0;entryDy=0;" target="nUxuXlOaQanOZV29W_tj-50">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-47" connectable="0" parent="1f3eEVwyFeHO0jPM4Pjp-8" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];" value="1" vertex="1">
<mxGeometry relative="1" x="-0.8894" y="-9" as="geometry">
<mxPoint x="-7" y="1" as="offset"/>
</mxGeometry>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-9" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-54" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0.481;entryY=1.019;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-61">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-10" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0;exitDx=0;exitDy=0;entryX=0.503;entryY=0.995;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-32">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-11" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.25;exitY=0;exitDx=0;exitDy=0;entryX=0.526;entryY=0.962;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-28">
<mxGeometry relative="1" as="geometry">
<Array as="points">
<mxPoint x="386" y="477"/>
<mxPoint x="551" y="477"/>
</Array>
</mxGeometry>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-13" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=-0.007;entryY=-0.061;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-37">
<mxGeometry relative="1" as="geometry">
<Array as="points">
<mxPoint x="411" y="664"/>
<mxPoint x="411" y="519"/>
<mxPoint x="574" y="519"/>
<mxPoint x="574" y="367"/>
</Array>
</mxGeometry>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-18" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Uses" vertex="1">
<mxGeometry height="30" width="60" x="-25" y="793" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-22" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Retrieves" vertex="1">
<mxGeometry height="30" width="60" x="559" y="620" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-23" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Picks up" vertex="1">
<mxGeometry height="30" width="60" x="522" y="553" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-24" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Creates a chance" vertex="1">
<mxGeometry height="30" width="106" x="453" y="523" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-25" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Finds player" vertex="1">
<mxGeometry height="30" width="79" x="453" y="486" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-27" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Finds any monsters" vertex="1">
<mxGeometry height="30" width="112" x="405" y="448" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-28" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Initiates<div><br></div>" vertex="1">
<mxGeometry height="30" width="60" x="282" y="527" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-29" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Creates chance" vertex="1">
<mxGeometry height="30" width="60" x="183" y="579" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-30" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Interacts with" vertex="1">
<mxGeometry height="30" width="60" x="-51" y="952" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-31" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Generates" vertex="1">
<mxGeometry height="30" width="60" x="-57" y="608" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-32" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Is created from" vertex="1">
<mxGeometry height="30" width="60" x="181" y="1117" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-34" edge="1" parent="1" source="nUxuXlOaQanOZV29W_tj-42" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=-0.004;entryY=0.822;entryDx=0;entryDy=0;entryPerimeter=0;" target="nUxuXlOaQanOZV29W_tj-30">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-35" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="Attacks during" vertex="1">
<mxGeometry height="30" width="60" x="157" y="268" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-36" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="-154" y="752" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-39" edge="1" parent="1" source="1f3eEVwyFeHO0jPM4Pjp-37" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;" target="nUxuXlOaQanOZV29W_tj-61" value="">
<mxGeometry relative="1" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-37" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="45" y="650" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-40" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="-81" y="823" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-41" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1..*" vertex="1">
<mxGeometry height="30" width="60" x="40" y="825" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-42" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="-160" y="840" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-43" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1..*" vertex="1">
<mxGeometry height="30" width="60" x="51" y="956" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-44" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="131" y="1093" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-45" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1..*" vertex="1">
<mxGeometry height="30" width="60" x="131" y="1141" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-46" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0<span style="background-color: transparent; color: light-dark(rgb(0, 0, 0), rgb(255, 255, 255));">..*</span>" vertex="1">
<mxGeometry height="30" width="60" x="388" y="850" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-48" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="237" y="796" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-51" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="394" y="780" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-52" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="512" y="693" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-53" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="619" y="650" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-54" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="468" y="638" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-55" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="617" y="547" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-56" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="613" y="424" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-58" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="419" y="638" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-59" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="617" y="341" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-60" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="388" y="638" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-62" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="362" y="638" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-64" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="495" y="329" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-67" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="0..*" vertex="1">
<mxGeometry height="30" width="60" x="321" y="638" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-68" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="321" y="388" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-69" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1" vertex="1">
<mxGeometry height="30" width="60" x="207" y="307" as="geometry"/>
</mxCell>
<mxCell id="1f3eEVwyFeHO0jPM4Pjp-70" parent="1" style="text;html=1;whiteSpace=wrap;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;rounded=0;" value="1..*" vertex="1">
<mxGeometry height="30" width="60" x="103" y="307" as="geometry"/>
</mxCell>
</root>
</mxGraphModel>
</diagram>
</mxfile>
