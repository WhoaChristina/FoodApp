import { NavLink } from "react-router-dom";
import './Start.css'
const StartComponent = ({name}) =>
{
    return(<>
    <div className="StartDiv">
        <h3 className="start-second-head">Idag rekommenderas: {name}</h3>
        <h1 className="start-head">Vad ska ätas?</h1>
        <NavLink to={'/Restaurants'} state ={{category : 'Asian'}}><button className="cat-btn">Asiatiskt</button></NavLink>
        <NavLink to={'/Restaurants'} state ={{category : 'Burger'}}><button className="cat-btn">Burgare</button></NavLink>
        <NavLink to={'/Restaurants'} state ={{category : 'Italian'}}><button className="cat-btn">Italienskt</button></NavLink>
        <NavLink to={'/Restaurants'} state ={{category : 'Dessert'}}><button className="cat-btn">Fika</button></NavLink>
        <NavLink to={'/Restaurants'} state ={{category : 'Other'}}><button className="cat-btn">Annat</button></NavLink>
        <div className="line"> </div>
    </div>
    </>)
}

export default StartComponent;