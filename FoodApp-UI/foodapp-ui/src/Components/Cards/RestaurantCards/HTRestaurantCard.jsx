import { NavLink } from "react-router-dom";
import './HTCRestaurantCard.css'
const HTRestaurantCard = ({item}) =>
{
    return(<>
    <div className="card">
        <div>
            <h3 className="restaurant-head">{item.name}, {item.rating} / 10</h3>
            <NavLink to={'/Dishes'} state ={{id : item.restaurantId, name : item.name}}><button className="dishes-btn">Rätter</button></NavLink>
        </div>
    </div>
    </>)
}
export default HTRestaurantCard;