import React from 'react';
import FontAwesome from '@expo/vector-icons/FontAwesome';
import FontAwesome5 from '@expo/vector-icons/FontAwesome5';
import MaterialIcons from '@expo/vector-icons/MaterialIcons';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import FlatListScreen from './scroll/FlatListScreen';
import SectionListScreen from './scroll/SectionListScreen';
import FormScreen from './scroll/FormScreen';
import { Ionicons } from '@expo/vector-icons';
const Tab = createBottomTabNavigator();




const ScrollScreen = () => {
  return (
    
      <Tab.Navigator>
        <Tab.Screen 
          name="Lista" 
          component={FlatListScreen} 
          options={{
            tabBarIcon: ({ color, size }) => (
                <MaterialIcons name="house" size={24} color="black" />
            ),
          }}
        />
        <Tab.Screen 
          name="Sessão" 
          component={SectionListScreen} 
          options={{
            tabBarIcon: ({ color, size }) => (
                <FontAwesome5 name="crow" size={24} color="black" />
            ),
          }}
        />
        <Tab.Screen 
          name="Formulário" 
          component={FormScreen} 
          options={{
            tabBarIcon: ({ color, size }) => (
                <FontAwesome name="user-secret" size={24} color="black" />
            ),
          }}
        />
      </Tab.Navigator>
   
  );
};

export default ScrollScreen;
