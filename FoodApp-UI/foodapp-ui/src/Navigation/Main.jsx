import {Route, Routes} from 'react-router-dom'
import ResturauntsContainer from '../Containers/Restaurants/RestaurantsContainer'
import DishesContainer from '../Containers/Dishes/DishesContainer'
import StartContainer from '../Containers/Start/StartContainer'

const Main = () =>
{
    return(<Routes>
        <Route exact path = '/' element ={<StartContainer />} />
        <Route path='/Restaurants' element ={<ResturauntsContainer />} />
        <Route path='/Dishes' element ={<DishesContainer />} />
    </Routes>)
}

export default Main;