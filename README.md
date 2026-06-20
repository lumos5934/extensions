# Enxtensions
여러 타입에 대한 Extension Method 모음 입니다. <br>

<br>
<br>
<br>

## 📖API

#### Transform
**`SetPositionX(x)`** : 월드 기준 X 위치만 변경합니다.  
**`SetPositionY(y)`** : 월드 기준 Y 위치만 변경합니다.  
**`SetPositionZ(z)`** : 월드 기준 Z 위치만 변경합니다.  
**`SetLocalPositionX(x)`** : 로컬 기준 X 위치만 변경합니다.  
**`SetLocalPositionY(y)`** : 로컬 기준 Y 위치만 변경합니다.  
**`SetLocalPositionZ(z)`** : 로컬 기준 Z 위치만 변경합니다.  
**`SetEulerX(x)`** : X 축 회전값(Euler)을 변경합니다.  
**`SetEulerY(y)`** : Y 축 회전값(Euler)을 변경합니다.  
**`SetEulerZ(z)`** : Z 축 회전값(Euler)을 변경합니다.  
**`SetScaleX(x)`** : X 스케일만 변경합니다.  
**`SetScaleY(y)`** : Y 스케일만 변경합니다.  
**`SetScaleZ(z)`** : Z 스케일만 변경합니다.  
**`LookAt2D(target)`** : 2D 평면에서 target 방향을 바라보도록 Z축 회전을 설정합니다.  
**`Reset()`** : localPosition / localRotation / localScale을 기본값으로 초기화합니다.  
**`GetChildren()`** : 모든 자식 Transform을 IEnumerable로 반환합니다.  

<br>

#### RectTransform
**`SetWidth(width)`** : width(sizeDelta.x)만 변경합니다.  
**`SetHeight(height)`** : height(sizeDelta.y)만 변경합니다.  
**`SetAnchoredX(x)`** : anchoredPosition의 X값만 변경합니다.  
**`SetAnchoredY(y)`** : anchoredPosition의 Y값만 변경합니다.  
**`Reset()`** : anchoredPosition / localRotation / localScale을 기본값으로 초기화합니다.  

<br>

#### Vector2
**`WithX`** : Vector2의 X 값을 변경한 새로운 Vector2를 반환합니다. <br>
**`WithY`** : Vector2의 Y 값을 변경한 새로운 Vector2를 반환합니다. <br>
**`DirectionTo`** : 현재 Vector2 위치에서 대상 위치로 향하는 정규화된 방향 벡터를 반환합니다. <br>
**`IsNear`** : 현재 위치와 대상 위치가 지정한 거리 이내인지 확인합니다. <br>
**`DistanceSqr`** : 두 Vector2 사이의 제곱 거리를 반환합니다. <br>
**`ToVector3`** : Vector2를 Vector3로 변환합니다. 기본 Y 값은 0으로 설정됩니다. <br>

<br>


#### Vector3
**`WithX`** : Vector3의 X 값을 변경한 새로운 Vector3를 반환합니다. <br>
**`WithY`** : Vector3의 Y 값을 변경한 새로운 Vector3를 반환합니다. <br>
**`WithZ`** : Vector3의 Z 값을 변경한 새로운 Vector3를 반환합니다. <br>
**`DirectionTo`** : 현재 Vector3 위치에서 대상 위치로 향하는 정규화된 방향 벡터를 반환합니다. <br>
**`IsNear`** : 현재 위치와 대상 위치가 지정한 거리 이내인지 확인합니다. <br>
**`DistanceSqr`** : 두 Vector3 사이의 제곱 거리를 반환합니다. <br>
**`ToVectorXY`** : Vector3의 X, Y 값을 사용하여 Vector2로 변환합니다. <br>
**`ToVectorXZ`** : Vector3의 X, Z 값을 사용하여 Vector2로 변환합니다. <br>
**`ToVectorYZ`** : Vector3의 Y, Z 값을 사용하여 Vector2로 변환합니다. <br>

<br>
