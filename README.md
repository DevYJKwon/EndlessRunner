# Endless Runner #

## 1. 미션 하나 추가로 넣기 ##
PlayerData.cs에 있는 CheckMissionsCount() 함수에서 missions.count의 개수를 3개까지 늘려서 미션을 추가함.

## 2. 캐릭터 Accessory 아이템 하나 넣기 ##
Bundle -> Character -> Cat으로 가서 RedSmart 아이템을 하나 추가하고, Character 인스펙터 창에서 element를 추가해서 아이템을 생성함.

## 3. 슬라이딩이나 점프 성공시 ##
 ### 3-1 캐릭터 스피드가 점점 빨라지고 장애물에 닿을 시 원래 스피드로 돌아온다 ###
 Character Input Controller.cs에서 슬라이딩과 점프가 끝난 경우에 TrackManager로 m_speed 프로퍼티를 사용하여 speed를 증가시킴. 만약 최고 속도에 도달했을 시 증가하지 않도록 설정하였음.
 ### 3-2 콤보 UI가 화면에 생성이 되고 콤보 숫자가 점점 올라간다 ###
 TrackManager.cs에 추가한 combo변수를 만들고 점프나 슬라이딩이 끝날 시 이를 증가시킴. 장애물과 충돌 시 Combo가 0으로 초기화되도록 함. UI에 Combo text를 추가하고 GameState.cs에서 필요한 부분을 추가하여 Combo UI구현

## 4. 스코어 배수에 따라 물고기 코인도 배수만큼 늘어난다 ##
CharacterCollider.cs에 있는 코인 충돌 이벤트 메소드에서 단순 +1이 아닌 trackManager의 multiplier 변수를 가져와서 이와 곱을 하여 배수에 따라 코인 충돌 시 증가하는 값을 수정하였다.
## 5. 장애물 하나 새로 만들어서 런타임 중에 생성되게 만들기 ##
IndustrialWareHouse 인스펙터에서 추가적으로 만든 StreetLight Obstacle을 추가해서 장애물을 추가함.

## 6.PowerUpItem 하나 프리펩으로 만들어서 상점에 넣고, 게임이 시작되면 인게임에서 생성이 되거나 사용하기 ##
Boost라는 PowerUpItem을 만들어서 게임 시작 시 사용하면 일정시간동안 최대 속도로 캐릭터가 달리게 만듦.


## 배운 점 ##
어려웠던 점으로는 새로운 프로젝트는 내가 그 코드를 짜면서 구조를 이해하고 있어서 수정하기 편했으나, 기존에 있는 프로젝트에서 기능을 추가하려니 그 구조를 이해하는데 시간이 필요했다. 
다행히 코드가 유지보수를 하기 쉽게 짜여져 있어 단순히 인스펙터에서 수정하거나 기존 프로퍼티를 이용하여 조금 수정하면 내가 원하는 기능을 충분히 넣을 수 있었다.
이를 통해 SOILD 법칙에서 Open-Closed 법칙이 왜 중요한지 알 수 있었다.
