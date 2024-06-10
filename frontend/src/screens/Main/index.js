import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';

const BottomTab = createBottomTabNavigator();

import { ContentIcon } from './style';
import { colors } from '../../colors.config';
import { MaterialIcons } from '@expo/vector-icons';
import { Text } from 'react-native';
import { Home } from '../Home';
import { RankingScreen } from '../RankingScreen';
import { DefaultWorkoutsScreen } from '../DefaultWorkoutsScreen';

export const Main = () => {
    
    const Profile = () => {
        return (
            <>
                <Text>Profile</Text>
            </>
        );
    };

    return (
        <Gradient>
            <BottomTab.Navigator
                initialRouteName={'Home'}
                screenOptions={({ route }) => ({
                    tabBarStyle: {
                        backgroundColor: '#27242B',
                        height: '10%',
                        paddingTop: 10,
                        paddingLeft: 40,
                        paddingRight: 40,
                        borderRadius: 20,
                        borderTopWidth: 0
                    },
                    tabBarActiveBackgroundColor: 'transparent',
                    tabBarShowLabel: false,
                    headerShown: false,

                    tabBarIcon: ({ focused }) => {
                        let iconName;

                        switch (route.name) {
                            case 'Home':
                                iconName = 'home';
                                break;
                            case 'DefaultWorkoutsScreen':
                                iconName = 'fitness-center';
                                break;
                            case 'Ranking':
                                iconName = 'star';
                                break;
                            case 'Profile':
                                iconName = 'person';
                                break;
                            default:
                                iconName = 'home';
                                break;
                        }
                        return (
                            <ContentIcon>
                                <MaterialIcons
                                    name={iconName}
                                    size={34}
                                    color={focused ? colors.orange : colors.white}
                                />
                            </ContentIcon>
                        );
                    }
                })}
            >
                <BottomTab.Screen name='Home' component={Home} />
                <BottomTab.Screen
                    name='DefaultWorkoutsScreen'
                    component={DefaultWorkoutsScreen}
                />
                <BottomTab.Screen name='Ranking' component={RankingScreen} />
                <BottomTab.Screen name='Profile' component={Profile} />
            </BottomTab.Navigator>
        </Gradient>
    );
}