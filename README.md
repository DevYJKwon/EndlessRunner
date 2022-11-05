#Endless Runner#

##1. 미션 하나 추가로 넣기##
PlayerData.cs에 있는 CheckMissionsCount() 함수에서 missions.count의 개수를 3개까지 늘려서 미션을 추가함.

##2. 캐릭터 Accessory 아이템 하나 넣기##
Bundle -> Character -> Cat으로 가서 RedSmart 아이템을 하나 추가하고, Character 인스펙터 창에서 element를 추가해서 아이템을 생성함.

##5. 장애물 하나 새로 만들어서 런타임 중에 생성되게 만들기##
IndustrialWareHouse 인스펙터에서 추가적으로 만든 StreetLight Obstacle을 추가해서 장애물을 추가함.

##6.PowerUpItem 하나 프리펩으로 만들어서 상점에 넣고, 게임이 시작되면 인게임에서 생성이 되거나 사용하기.##
Boost라는 PowerUpItem을 만들어서 게임 시작 시 사용하면 일정시간동안 최대 속도로 캐릭터가 달리게 만듦.


##배운 점##
어려웠던 점으로는 새로운 프로젝트는 내가 그 코드를 짜면서 구조를 이해하고 있어서 수정하기 편했으나, 기존에 있는 프로젝트에서 기능을 추가하려니 그 구조를 이해하는데 시간이 필요했다. 
다행히 코드가 유지보수를 하기 쉽게 짜여져 있어 단순히 인스펙터에서 수정하거나 기존 프로퍼티를 이용하여 조금 수정하면 내가 원하는 기능을 충분히 넣을 수 있었다.
이를 통해 SOILD 법칙에서 Open-Closed 법칙이 왜 중요한지 알 수 있었다.
