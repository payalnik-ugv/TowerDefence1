
> Как использовать NavMesh в Unity >> https://www.youtube.com/watch?v=atCOd4o7tG4
> NavMesh поиск пути и перемещение по карте >> https://www.youtube.com/watch?v=LrDYS4RxCXA
> How to fix character floating above the ground when using NavMesh in Unity 3D >> https://www.youtube.com/watch?v=-xMA2eiJsmk
  ================================
  NavMesh (Navigation Mesh) — это встроенная в движок Unity система поиска путей и навигации
                              Она представляет собой скрытую сетку, которая указывает искусственному интеллекту (ИИ), где персонажи могут безопасно ходить, игнорируя стены, пропасти и другие препятствия
                              >> https://docs.unity3d.com/2022.2/Documentation/ScriptReference/AI.NavMesh.html
							  + Как это работает в Unity:
							    - Baking (Запекание): движок анализирует геометрическую форму вашей 3D-сцены или 2D-уровня и генерирует навигационную сетку (синюю область), по которой может перемещаться персонаж
								- NavMesh Agent (Агент): это компонент, который вешается на NPC, врагов или союзников
								                         Агент знает алгоритм поиска пути A* (A-star) и вычисляет самый короткий маршрут из точки А в точку Б, плавно обходя статические и динамические препятствия
														 >> https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/AboutAgents.html
								- NavMesh Obstacle (Препятствие): позволяет объектам, таким как бочки, ящики или даже закрывающиеся двери, временно изменять навигационную сетку, заставляя ИИ перестраивать путь в реальном времени
							  + Основные компоненты системы:
							    - Navigation (Вкладка Навигация): используется для разметки объектов и настройки параметров запекания (радиус шага, высота прыжка, ширина агента)
								- NavMesh Surface: это главный компонент, чтобы обозначить зону, где ИИ может ходить
								                   Он задает размер конкретного типа агента (например, радиус и высоту)
								- NavMesh Modifier: позволяет выборочно добавлять или исключать определенные объекты из зоны построения пути
								                    С его помощью можно настроить зоны, которые ИИ будет избегать
								- NavMesh Modifier Volume: объемный триггер, который меняет «стоимость» прохода (Cost) по определенной области для ИИ внутри этого куба или сферы
								                           Полезно, чтобы ИИ обходил грязь или воду стороной
								- NavMesh Link: позволяет создавать виртуальные мосты или точки телепортации, чтобы ИИ мог перепрыгивать через пропасти, подниматься по лестницам или открывать двери
  NavMesh-Building Components — это более продвинутая система 'NavMesh', которая доступна по умолчанию в Unity >> https://github.com/Unity-Technologies/NavMeshComponents
                              — это специальный набор инструментов в игровом движке Unity, который позволяет строить (запекать) и настраивать пути перемещения для ИИ
							   (она делает процесс создания ИИ гораздо более гибким и динамичным по сравнению со стандартным инструментом NavMesh)
							   >> https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.0/manual/index.html
							   >> https://docs.unity3d.com/ru/2021.1/Manual/NavMesh-BuildingComponents.html
  ================
  >>> (Code Monkey * Руководство по Unity | Как использовать Unity NavMesh Pathfinding) https://www.youtube.com/watch?v=atCOd4o7tG4&t=29s
       ----------------------------------
	   Shader Graph
	   ProBuilder >> https://www.youtube.com/watch?v=h84xD2NsMI8
	   VideoPlayer
	   RenderTexture
	   Visual Scripting
	   Assembly Definition
	   Grid System
	   Post Processing
	   Render Pipelines
	   Game Object Icons
	   Pivot - Center
	   TrailRenderer
	   TextMeshPro
	   Resources
  ================
  "MVP" Wendi * Механики Unity:
  (#3 - Как сделать врага преследующего персонажа)  >>  https://www.youtube.com/watch?v=jxp4cuB1rgk
  
  "MVP" Wendi * Создание своей игры на Unity в стиле Tower Defence:
  (#1 - Создание карты и врагов)  >>  https://www.youtube.com/watch?v=UoEzU8rHYTM
   >> https://www.youtube.com/watch?v=UoEzU8rHYTM&t=17s >> https://github.com/Unity-Technologies/NavMeshComponents
    > Project > Create > Folder = Assets\Prefabs, Assets\Scripts
    > Hierarchy > Create Empty >> Inspector > (Rename) Map
	                           >> Inspector - Transform > Reset
				> (Drag on Drop) Project - Assets/Prefabs >> (Double click) Map
   >> https://youtu.be/UoEzU8rHYTM?t=462 >> https://youtu.be/UoEzU8rHYTM?t=507
   >> https://youtu.be/UoEzU8rHYTM?t=598 >> https://youtu.be/UoEzU8rHYTM?t=603
    X (Select) Hierarchy - Map - Cells - Plane (Brown) > Inspector - 'Add Component' - 'Nav Mesh Surface'
    > (Select) Hierarchy - Map > Create Empty >> (Rename) Cells
	> Hierarchy > 3D Object > Plane ... (полигон 10x10)
	> Hierarchy - Map > (Drag on Drop) Hierarchy - Map - Cells
	> Project - Assets/Prefabs > Create > Material = Land, Road
    > (Select) Hierarchy - Map - Cells - Planes (Green|s) > Inspector - Layer - 'Add Layer' = Map, Land, Road
    > (Select) Hierarchy - Map - Cells - Planes (Greens) > Inspector - Layer = Land
    > (Select) Hierarchy - FinishWall > Inspector - Box Collider = Is Trigger
	> (Select) Hierarchy - Map > Inspector - 'Add Component' - 'Nav Mesh Surface'
	                           > Inspector - 'Nav Mesh Surface' - Include Layers = (Nothing) Road > 'Bake'
	> (Get out) Hierarchy - Map >> (Перетащить карту)
    > (Drag on Drop) Project - Assets/Prefab - Map > Scene
	  --------------
	> Установка пакета:
	  - Перейдите в 'Window' > 'Package Manager'
	  - Выберите пакет 'AI Navigation' и нажмите 'Install'
	> Создайте объекты, по которым будет ходить персонаж (Plane, стены, лестницы)
	> Убедитесь, что для этих объектов включена галочка 'Navigation' - 'Static' (в правом верхнем углу инспектора)
	> Выберите объект земли > в 'Inspector' нажмите 'Add Component' > добавьте 'NavMesh Surface' > установите 'Agent Type' = 'Humanoid'
	> Включить кнопку 'Gizmos' - находится во вкладке 'Scene' на панели инструментов в верхней части окна > нужно нажать по самой кнопке 'Gizmos' чтобы активировать ее (выделена голубым)
	> Внутри окна, во вкладкуе 'Scene', находится модульное окно 'All Navigation' - здесь нужно выделить чекбоксом: 'Surfaces' > 'Show NavMesh'
	  --------------
	> можно скопировать ранее созданый обект 'Map' > переименовать на 'Enemy' > удаляем все внутренние обьекты
	> Hierarchy > 3D Object > Cylinder
	> Hierarchy - Enemy - Cylinder >> Inspector - Capsule Collider > Remove Component
	> Hierarchy - Enemy >> Inspector > Add Component > 'Nav Mesh Agent'
	> Project - Assets/Prefabs > Create > Material - (Rename) 'Enemy' >> Drag on Drop)>> (Scene) Cylinder
	> Inspector - 'Enemy' > Add Component > New Script - (Rename) 'EnemyUnit'
	> Microsoft Visual Studio > (Edit) 'EnemyUnit.cs'
	
	>> https://youtu.be/UoEzU8rHYTM?t=1080
	> Добавление ИИ (Агента)
   ----------------------------
  
  ================
  >>> (Учебное пособие по NavMesh) https://medium.com/@moesio.f/https-medium-com-moesio-f-unity-navmesh-tutorial-en-bfeeccd6169a
                                   >> https://github.com/Unity-Technologies/NavMeshComponents
								   >> https://www.golden-tamarin.com/2023/01/16/a-healthy-navmesh-in-unity
								    > NavMeshSurface – для создания и активации поверхности NavMesh для одного типа агентов
									                   >> https://github.com/Unity-Technologies/NavMeshComponents/blob/master/Documentation/NavMeshSurface.md
								    > NavMeshModifier — влияет на генерацию NavMesh для типов областей NavMesh на основе иерархии преобразований
									                    >> https://github.com/Unity-Technologies/NavMeshComponents/blob/master/Documentation/NavMeshModifier.md
								    > NavMeshModifierVolume – влияет на генерацию NavMesh-сетки для областей NavMesh-типа на основе объема
									                          >> https://github.com/Unity-Technologies/NavMeshComponents/blob/master/Documentation/NavMeshModifierVolume.md
								    > NavMeshLink – соединяет одинаковые или разные поверхности NavMesh для одного типа агентов
									                >> https://github.com/Unity-Technologies/NavMeshComponents/blob/master/Documentation/NavMeshLink.md
