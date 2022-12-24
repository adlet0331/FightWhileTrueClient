# 수익이 되는 간단한 모바일 게임 개발
## 목적: 수익이 들어오는 (3일 이상 컨텐츠가 지속 가능한) 모바일 게임을 만들어보자

## 기획

장착한 칼들의 기본 공격력 + 옵션으로 산출된 공격력으로 스테이지를 뚫으며 보상을 얻으며 무한 성장을 하는 게임

### [장비] 
- 획득: 고정된 가격의 코인을 소모한 뽑기
- 강화: 다른 장비들을 넣어서 강화
> - 강화 옵션의 증가
> > - 선형으로 증가. (+ 초기 값 10%)
> - 강화 비용
> > - 강화석 + 코인
> > - 강화석은 뽑기, 장비 분해를 통해 획득 가능
> > - 코인은 강화 단계에 따라 다르게
- 분해: 강화석을 획득 가능
> - 레어도, 강화도에 따라 획득
- 레어도: 옵션의 수치에 차이가 있음
- 옵션: 칼의 종류 별로 정해져 있음
> - 옵션의 종류 (/로 분리 되어있는 것은 앞의 것은 낮은 레어도, 뒤의 것은 높은 레어도에서 나오는 옵션)
 > - 더 높은 스테이지 지향
> > - 공격력 + N / + n%
> > - 기본 공격력 획득량 + N
> > - 코인 획득량 + N / + n%
 > - 원활한 오토 지향
> > - 공격 후 딜레이 - n%
> > - 적 달리기 속도 증가 + n%
> > - 

- 강화: 필요 재화, 옵션 증가량

### [플레이어]
- 공격력: (캐릭터 기본 공격력 + 칼의 기본 공격력) * (장비 옵션 %)
- 코인: 재화
- 장비: 장비이자 강화 재료
- 난이도: 상, 중, 하로 나뉘어짐.
> - 적 AI의 공격 딜레이 조정. 
> - 상: 보상 x 1.5, 중: 보상 x 1.0, 하: 보상 x 0.8

### [스테이지]
- 플레이어는 움직이지 않고, 적이 움직이는 타이밍에 맞추어 공격을 해서 적의 HP를 모두 깎으면 승리

- 적 HP는 일정 비율로 증가. 플레이어에게 UI로만 알려줌
> - 100 * (1.2) ^ (stage - 1)
> - 1.2 ^ 10 = 6.2

- 데미지
> - 공격력 만큼 적에게 데미지가 들어감. 
> - 플레이어는 1번 맞으면 죽음

- 딜레이
> - 공격에는 선딜 + 후딜 존재. 
> - 플레이어의 선딜이 적 보다 짧음

- 스테이지 클리어 보상
> - Stage에 비례하게, 다중 클리어 상정하고 설계
> - 보상: 기본 공격력 상승, 코인
> > - 기본 공격력 상승: 경험치, 레벨 개념. 시간으로 살 수 있는 개념. 
> > - 코인: 재화 수급

### [랭킹]
- 간단한 DB가 있는 서버로 랭킹 만들어 보기
1. 공격력
2. 클리어 한 스테이지
3. 한 번에 클리어 한 스테이지 (?)

### [재미]
- 스테이지 클리어 보상 + 일일 보상 + 광고 보상 으로 장비를 강화하며 강해지는 성취감
- 공격력 수치 뽕
- 격겜 비스무리한, 스테이지 클리어 성취감


# TODO

> Input Block 제대로 만들기
> Managers Monobehavior을 빼고 클래스화 해서 한 매니저에서 관리하게 하기
