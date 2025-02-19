﻿using Decorator;

IComponent component = 
    new ConcreteDecorator2(
        new ConcreteDecorator1(
            new ConcreteDecorator1( 
                new ConcreteComponent()
            )
        )
    );
component.Operation();