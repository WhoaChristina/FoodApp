import { NavLink } from "react-router-dom";
import './HTCRestaurantCard.css'
const RestaurantCard = ({item}) =>
{
    return(<>
    <div className="card">
        <div>
            <h3 className="restaurant-head">{item.name}</h3>
            <NavLink to={'/Dishes'} state ={{id : item.restaurantId, name : item.name}}><button className="dishes-btn">Rätter</button></NavLink>
        </div>
    </div>
    </>)
}
export default RestaurantCard;